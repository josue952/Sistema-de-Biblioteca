using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAE.Clases
{
    internal class LibroDB
    {
        private string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
        private decimal precioLibro;

        public LibroDB(decimal precioLibro)
        {
            this.precioLibro = precioLibro;
        }

        public List<LibroDB> Get(string nombreLibro, string nombreEditorial)
        {
            List<LibroDB> libros = new List<LibroDB>();
            string query = "SELECT L.PrecioLibro FROM Compras C " +
                "INNER JOIN Libros L ON C.Libros = L.ISBN " +
                "INNER JOIN Editorial E ON C.Editorial = E.CodigoEditorial " +
                "WHERE L.NombreLibro = '"+nombreLibro+"' AND E.NombreEditorial = '"+nombreEditorial+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    decimal precioLibro = reader.GetDecimal(0);
                    LibroDB libro = new LibroDB(precioLibro);
                    libros.Add(libro);
                }
                reader.Close();
                connection.Close();
            }

            return libros;
        }
    }
}
