using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsRevisor.Client
{
    public partial class Form1 : Form
    {
        public static List<ItemClass> _ite = new List<ItemClass>();
        public Form1()
        {
            InitializeComponent();
        }
        public static string ip = "127.0.0.1";
        public static int port = 1725;
        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            connectForm formConnect = new connectForm();
            if (formConnect.ShowDialog(this) == DialogResult.OK)
            {
                port = int.Parse(formConnect.textBox2.Text);
                ip = formConnect.textBox1.Text;
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(formConnect.textBox1.Text)) {
                    port = int.Parse(formConnect.textBox2.Text);
                    ip = formConnect.textBox1.Text;
                }
            }
            formConnect.Dispose();
            toolStripStatusLabel2.Text = "Подключён к серверу: " + ip + ":" + port;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true) { 
                ListenSocket();
                Thread.Sleep(3000);
                }
            }).Start();
        }

        public void ListenSocket()
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.Connect(ipPoint);
                string message = "action:getItems";
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);
                // получаем ответ
                data = new byte[1024]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт
                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                Debug.WriteLine("ответ сервера: " + builder.ToString());
                _ite = JsonConvert.DeserializeObject<ItemClass[]>(builder.ToString()).ToList();
                // закрываем сокет
                //socket.Shutdown(SocketShutdown.Both);
                //socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true) {
                    if (_ite.Count > 0) { 
                        RefreshLists();
                    }
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public void RefreshLists()
        {
            listBox1.Invoke((MethodInvoker)delegate {
                listBox1.Items.Clear();
                foreach (ItemClass it in _ite)
                {
                    if (it != null) 
                        { 
                        if (it._location == "Склад")
                        {
                            listBox1.Items.Add($"[{it._id}]: {it._name} - {it._count}");
                        }
                        
                    }
                }
                });
            listBox1.Invoke((MethodInvoker)delegate {
                listBox2.Items.Clear();
                foreach (ItemClass it in _ite)
                {
                    if (it != null) 
                    {
                        if (it._location == "Магазин")
                        {
                            listBox2.Items.Add($"[{it._id}]: {it._name} - {it._count}");
                        }
                    }
                }
            });

        }
    }
}
