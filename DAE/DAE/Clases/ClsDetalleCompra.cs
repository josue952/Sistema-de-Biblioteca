using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAE.Clases
{
    internal class ClsDetalleCompra
    {
        public ClsDetalleCompra()
        {
        }

        public int CodigoCompra { get; set; }
        public string NombreLibro { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal => Cantidad * Precio;

        public DataTable getDetallesCompra(int codigoCompra)
        {
            string query = "SELECT D.CodigoDetalleCompra, L.NombreLibro AS Libro, D.PrecioLibro, D.Cantidad, D.SubTotal " +
                "FROM DetalleCompras D " +
                "INNER JOIN Libros L ON D.Libro = L.ISBN " +
                "WHERE D.CodigoCompra = @CodigoCompra;";
            string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CodigoCompra", codigoCompra);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}
