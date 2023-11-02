using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Windows.Forms;

namespace DAE.DAO
{
     public abstract class ConnectionDataBase
     {
        private readonly string connectionString;

        public ConnectionDataBase()
        {
           connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public string getConnectionString()
        {
            return connectionString;
        }
     }
}
