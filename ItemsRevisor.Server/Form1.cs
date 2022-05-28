using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                //...
            }
        }
    }
}
