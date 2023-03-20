using Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stockage
{
    public abstract class BaseDao
    {
        private SQLiteConnection connection;
        
        public void ExecuteNonQuery(string req)
        {
            connection.Open();
            var com = connection.CreateCommand();
            com.CommandText = req;
            com.ExecuteNonQuery();
            connection.Close();
        }

        public SQLiteDataReader ExecuteQuery(string req) 
        {
            connection.Open();
            var com = new SQLiteCommand(req, connection);
            return com.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
