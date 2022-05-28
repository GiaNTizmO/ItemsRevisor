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
    public partial class DebugTerminal : Form
    {
        public static bool _doRefresh = false;
        public static List<string> debug_logs = new List<string>();
        public static Logger log = new Logger();
        public DebugTerminal()
        {
            InitializeComponent();
            comboBox1.Items.Add("Debug logging");
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
               
                RefreshTermnial(comboBox1.SelectedIndex);
            }).Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Showing debug logs");
            _doRefresh = true;
        }
        
        public void RefreshTermnial(int id)
        {
            while (true) {
                try { 
                comboBox1.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                   
                    if (_doRefresh)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.AddRange(debug_logs.ToArray());
                        _doRefresh = !_doRefresh;
                    }
                });
                }
                catch (InvalidOperationException) { }


                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleCommandHandler(textBox1.Text);
            textBox1.Text = String.Empty;
        }

        private void SampleCommandHandler(string cmd)
        {
            if (cmd.StartsWith("ping"))
            {
                string _dst = cmd.Split(' ')[1];
                log.DebugWriteLine($"Sending ECHO packets to: {_dst}");
            }
            else
            {
                log.DebugWriteLine($"Unknown command: {cmd}");
            }
        }
    }
    public class Logger{
        public Logger() { }
        public void DebugWriteLine(object _obj) { DebugTerminal.debug_logs.Add(_obj.ToString()); DebugTerminal._doRefresh = true; }
    }
}
