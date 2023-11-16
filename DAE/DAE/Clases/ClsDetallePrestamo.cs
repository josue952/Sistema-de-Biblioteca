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
    class ClsDetallePrestamo
    {
        public ClsDetallePrestamo()
        {
        }
        public int CodigoPrestamo { get; set; }
        public string NombreLibro { get; set; }
        public int Cantidad { get; set; }
        public DataTable getDetallesPrestamo(int codigoPrestamo)
        {
            string query = "SELECT D.CodigoDetallePrestamo, L.NombreLibro AS Libro, D.Cantidad " +
                "FROM DetallePrestamo D " +
                "INNER JOIN Libros L ON D.Libro = L.ISBN " +
                "WHERE D.CodigoPrestamo = @CodigoPrestamo;";
            string connectionString = connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CodigoPrestamo", codigoPrestamo);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


    }
}
