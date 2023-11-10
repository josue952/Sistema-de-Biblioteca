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
        //esta clase es para obtener los nombres de los libros de la base de datos segun la categoria
        private string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
        public string nombreLibro { get; set; }

        public LibroDB(string nombreLibro)
        {
            this.nombreLibro = nombreLibro;
        }

        public List<LibroDB> Get(string nombreCategoria)
        {
            List<LibroDB> libros = new List<LibroDB>();
            string query = $"SELECT L.NombreLibro FROM Libros L INNER JOIN Categoria C ON L.Categoria = C.CodigoCategoria WHERE C.NombreCategoria = '{nombreCategoria}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LibroDB libro = new LibroDB("");
                            libro.nombreLibro = reader["NombreLibro"].ToString();
                            libros.Add(libro);
                        }
                    }
                }
            }

            return libros;
        }
    }
}
