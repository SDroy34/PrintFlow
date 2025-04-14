using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdConnetion.Connection
{
     public abstract class BdConnection
    {
        private readonly string _connectionString;
        protected SQLiteConnection connectionBd;

        public BdConnection(string path)
        {
            _connectionString = $"DataSource={path}";
        }

        public void AbrirBd()
        {
            connectionBd = new SQLiteConnection(_connectionString);
            connectionBd.Open();
        }
        public void CerrarBd()
        {
            if(connectionBd != null && connectionBd.State == System.Data.ConnectionState.Open)
                connectionBd.Close();
        }
    }
}
