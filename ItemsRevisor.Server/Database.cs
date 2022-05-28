using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
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

        public static void Setup(string dbname)
        {
            var connection = new SqliteConnection(connectionString + dbname);
            if (!File.Exists(dbname))
            {
                log.DebugWriteLine("First time dbusing!");
                _isDBFirstTimeUsed =true;
            }
            try
            {
                connection.Open();
                log.DebugWriteLine("SQLite connection etablished with: " + dbname);
            }
            catch (Exception ex) {
                log.DebugWriteLine("SQLite connection exception : " + ex.ToString());
            }
        }
    }
}
