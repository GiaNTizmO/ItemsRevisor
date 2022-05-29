using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ItemsRevisor.Server
{
    public static class SocketManager
    {
        public static void LaunchSocketServerThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                LaunchSocketServer();
            }).Start();
        }

        public static void LaunchSocketServer()
        {
            Logger log = new Logger();
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(Form1._socket_ip), Form1._socket_port);
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listenSocket.Bind(ipPoint);

                listenSocket.Listen(10);
                log.DebugWriteLine("Сокет сервер слушает порт: " + Form1._socket_port);
                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; 
                    byte[] data = new byte[1024];
                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);
                    if (builder.ToString() == "action:getItems")
                    {
                        log.DebugWriteLine("Получен запрос на выдачу товаров");
                        List<ItemClass> _itemsContainer = new List<ItemClass>();
                        string sqlExpression = "SELECT * FROM Items";
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
                                    _itemsContainer.Add( new ItemClass(int.Parse(id.ToString()), (string)name, int.Parse(count.ToString()), (string)location)); //SUPERIOR C STYLE VARIABLE CAST BECAUSE I AM TOO LAZY FOR THIS SH*T
                                }
                            }
                        }
                        
                        JArray array = JArray.FromObject(_itemsContainer);
                        log.DebugWriteLine(array.ToString());
                        data = Encoding.Unicode.GetBytes(array.ToString());
                        handler.Send(data);
                    }
                    log.DebugWriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                    
                    //data = Encoding.Unicode.GetBytes(array);
                    //handler.Send(data);
                    //handler.Shutdown(SocketShutdown.Both);
                    //handler.Close();
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                log.DebugWriteLine(ex.Message);
            }
        }
    }
}
