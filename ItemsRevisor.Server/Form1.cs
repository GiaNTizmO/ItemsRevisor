using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsRevisor.Server
{
    public partial class Form1 : Form
    {
        Logger log = new Logger();
        public Form1()
        {
            InitializeComponent();
        }

        public static bool _isDBLoaded = false;
        public static string _DBname;
        public static bool _isSocketServerStarted = false;
        public static int _connectedClients = 0;
        public static int _socket_port = 1725;
        public static string _socket_ip = "127.0.0.1";
        public static int _itemsCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            log.DebugWriteLine("Form loading");
            
            //Wait load db
            //launch socket server
            //handle connections
            //profit bruh
        }
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Звоните Алихану");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простая программа для работы с товарами магазина, как её видел автор без ТЗ :)");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void консольОтладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DebugTerminal().Show();
        }

        private void создатьБДToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string txtResult = "";
            DBSelector testDialog = new DBSelector();

      
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
  
                txtResult = testDialog.textBox1.Text;
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(testDialog.textBox1.Text)) { txtResult = testDialog.textBox1.Text; }
            }
            if (!String.IsNullOrEmpty(txtResult))
            {
                _DBname = txtResult;
                ConnectDB(_DBname);
            }
                
            testDialog.Dispose();
        }

        public void ConnectDB(string _DBname)
        {
            Database.Setup(_DBname);
            Thread.Sleep(500);
            RefreshLists();
            SocketManager.LaunchSocketServerThread();
            tooltip_status.Text = "Работает";
        }

        private void загрузитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Database files (*.db, *.sqlite)|*.db;*.sqlite";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _DBname = openFileDialog1.FileName;
                ConnectDB(_DBname);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var cmd = Database.command;
           cmd.CommandText = $"INSERT INTO Items (Name, Count, Location) VALUES ('{textBox_create_name.Text}', {int.Parse(textBox_create_count.Text)}, '{comboBox_creation.Text}')";
           try {
            int number = cmd.ExecuteNonQuery();
                if (number > 0) { log.DebugWriteLine("Created item: " + textBox_create_name.Text); }
            }
            catch (Exception ex)
            {
                log.DebugWriteLine("Error : " + ex.ToString());
            }
            RefreshLists();
        }

        public static ItemClass getItemById(int _id)
        {
            string sqlExpression = "SELECT * FROM Items WHERE _id = " + _id;
            SQLiteCommand command = new SQLiteCommand(sqlExpression, Database.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var id = reader.GetValue(0);
                        var name = reader.GetValue(1);
                        var count = reader.GetValue(2);
                        var location = reader.GetValue(3);
                        return new ItemClass(int.Parse(id.ToString()), (string)name, int.Parse(count.ToString()), (string)location); //SUPERIOR C STYLE VARIABLE CAST BECAUSE I AM TOO LAZY FOR THIS SH*T
                    }
                }
            }
            return null;
        }

        public void RefreshLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            _itemsCount = 0;
            string sqlExpression = "SELECT * FROM Items";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, Database.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        _itemsCount++;
                        var id = reader.GetValue(0);
                        var name = reader.GetValue(1);
                        var count = reader.GetValue(2);
                        var location = reader.GetValue(3);
                        if (location.ToString() == "Склад")
                        {
                            listBox1.Items.Add($"[{id}]: {name} - {count}");
                        }
                        else if (location.ToString() == "Магазин")
                        {
                            listBox2.Items.Add($"[{id}]: {name} - {count}");
                        }
                        else
                        {
                            log.DebugWriteLine($"WARN: Element not valid location: {id} \t {name} \t {location}");
                        }
                    }
                }
            }
        }

        public bool _listbox1_selecting = false;
        public bool _listbox2_selecting = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listbox2_selecting) { listBox2.ClearSelected(); _listbox1_selecting = true; }
            if (listBox1.SelectedItem != null)
            {
                string selected = (string)listBox1.SelectedItem;
                var _arr = selected.Split(':');
                string clean = Regex.Replace(_arr[0], "[^0-9 ]", "");
                int id = int.Parse(clean);
                UpdateEditor(getItemById(id));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listbox1_selecting) { listBox1.ClearSelected(); _listbox2_selecting = true; }
            if (listBox2.SelectedItem != null) { 
            string selected = (string)listBox2.SelectedItem;
            var _arr = selected.Split(':');
            string clean = Regex.Replace(_arr[0], "[^0-9 ]", "");
            int id = int.Parse(clean);
            UpdateEditor(getItemById(id));
            }
        }

        public void UpdateEditor(ItemClass _class)
        {
            textBox_editor_id.Text = _class._id.ToString();
            textBox_editor_name.Text = _class._name;
            textBox_editor_count.Text = _class._count.ToString();
            if (_class._location == "Склад")
            {
                comboBox_editor_location.SelectedIndex = 0;
            }
            else if (_class._location == "Магазин")
            {
                comboBox_editor_location.SelectedIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Frankfurt' CustomerID = 1;
            string sqlExpression = $"UPDATE Items SET Name='{textBox_editor_name.Text}', Count = {int.Parse(textBox_editor_count.Text)}, Location = '{comboBox_editor_location.Text}' WHERE _id='{int.Parse(textBox_editor_id.Text)}'";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, Database.connection);
            int number = command.ExecuteNonQuery();
            RefreshLists();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"DELETE FROM Items WHERE _id='{int.Parse(textBox_editor_id.Text)}'";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, Database.connection);
            int number = command.ExecuteNonQuery();
            RefreshLists();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }
    }
}
