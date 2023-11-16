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
        public decimal precioLibro { get; set; }
        public int stockLibro { get; set; }

        public LibroDB(string nombreLibro)
        {
            this.nombreLibro = nombreLibro;
        }

        public LibroDB(decimal precioLibro)
        {
            this.precioLibro = precioLibro;
        }

        public LibroDB(int stockLibro)
        {
            this.stockLibro = stockLibro;
        }

        public List<LibroDB> GetNombreLibro(string nombreCategoria)
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
        public List<LibroDB> GetPrecios(string nombreCategoria, string nombreLibro)
        {
            List<LibroDB> preciosLibros = new List<LibroDB>();
            string query = $"SELECT L.PrecioLibro FROM Libros L INNER JOIN Categoria C ON L.Categoria = C.CodigoCategoria WHERE C.NombreCategoria = '{nombreCategoria}' AND L.NombreLibro = '{nombreLibro}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LibroDB precioLibro = new LibroDB(0);
                            precioLibro.precioLibro = Convert.ToDecimal(reader["PrecioLibro"]);
                            preciosLibros.Add(precioLibro);
                        }
                    }
                }
            }

            return preciosLibros;
        }

        public List<LibroDB> GetStock(string nombreCategoria, string nombreLibro)
        {
            List<LibroDB> stockLibros = new List<LibroDB>();
            string query = $"SELECT L.StockLibro FROM Libros L INNER JOIN Categoria C ON L.Categoria = C.CodigoCategoria WHERE C.NombreCategoria = '{nombreCategoria}' AND L.NombreLibro = '{nombreLibro}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LibroDB libro = new LibroDB(0);
                            libro.stockLibro = Convert.ToInt32(reader["StockLibro"]);
                            stockLibros.Add(libro);
                        }
                    }
                }
            }

            return stockLibros;
        }
    }
}
