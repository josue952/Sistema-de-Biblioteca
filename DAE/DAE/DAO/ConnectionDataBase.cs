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
            connectionString = "Data Source=THELOL952\\SQLEXPRESS; DataBase=Registro; Integrated Security=True";
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
