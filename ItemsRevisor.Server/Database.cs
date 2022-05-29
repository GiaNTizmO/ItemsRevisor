
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsRevisor.Server
{
    public static class Database
    {
        public static Logger log = new Logger();
        public static string connectionString = "Data Source=";
        public static bool _isDBInitialized = false;
        public static bool _isDBFirstTimeUsed = false;
        public static SQLiteCommand command;

        public static void Setup(string dbname)
        {
            var connection = new SQLiteConnection(connectionString + dbname);
            if (!File.Exists(dbname))
            {
                log.DebugWriteLine("First time dbusing!");
                _isDBFirstTimeUsed =true;
            }
            try
            {
                connection.Open();
                log.DebugWriteLine("SQLite connection etablished with: " + dbname);
                Form1.ActiveForm.Text = "ItemsRevisor - БД: " + dbname;
                command = new SQLiteCommand();
                command.Connection = connection;

                if (_isDBFirstTimeUsed)
                {
                    command.CommandText = "CREATE TABLE Items(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, Count INTEGER NOT NULL, Location TEXT NOT NULL)";
                    command.ExecuteNonQuery();
                    log.DebugWriteLine("Created Items table. Database successfully initialized!");
                }
            }
            catch (Exception ex) {
                log.DebugWriteLine("SQLite connection exception : " + ex.ToString());
            }
        }
    }
}
