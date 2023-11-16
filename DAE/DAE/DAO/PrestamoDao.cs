using DAE.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAE.Interfaz;

namespace DAE.DAO
{
    class PrestamoDao: ConnectionDataBase
    {
        public DataTable consultar(string tabla)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todas las compras
            string sql = "";
            SqlConnection con = GetConnection();//extaer conexion
            if (tabla == "listaCategorias")
            {
                sql = "SELECT CodigoCategoria, NombreCategoria FROM Categoria";

            }
            else if (tabla == "listaUsuarios")
            {
                sql = "SELECT CodigoUser, UserName FROM Usuarios";
            }
            else if (tabla == "listaLibros")
            {
                sql = "SELECT ISBN, NombreLibro FROM Libros";
            }
            else
            {
                sql = "SELECT P.CodigoPrestamo, U.UserName AS NombreUsuario, P.FechaPrestamo, P.Estado " +
                    "FROM Prestamo P " +
                    "JOIN Usuarios U ON P.Usuario = U.CodigoUser " +
                    "WHERE U.UserName = '"+UserLoginCache.userName+"'";
            }
            try
            {
                con.Open(); // Abrir la conexión
                SqlCommand cmd = new SqlCommand(sql, con); // Configurar el comando SQL

                string connectionString = getConnectionString(); // Extraer cadena de conexión
                adapter = new SqlDataAdapter(cmd); // Ejecutar consulta usando el comando

                adapter.Fill(datos);
            }
            catch (SqlException error)
            {
                MessageBox.Show($"Ocurrio el siguient error: {error.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
            return datos;
        }

        public List<ClsDetallePrestamo> ObtenerDetallesPorIdPrestamo(int idPrestamo)
        {

            List<ClsDetallePrestamo> detalles = new List<ClsDetallePrestamo>();

            string query = "SELECT CodigoDetallePrestamo, NombreLibro, Cantidad, Precio FROM DetallePrestamo WHERE CodigoPrestamo = @IdPrestamo";

            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsDetallePrestamo detalle = new ClsDetallePrestamo();
                            detalle.CodigoPrestamo = Convert.ToInt32(reader["CodigoPrestamo"]);
                            detalle.NombreLibro = reader["NombreLibro"].ToString();
                            detalle.Cantidad = Convert.ToInt32(reader["Cantidad"]);

                            detalles.Add(detalle);
                        }
                    }
                }
            }

            return detalles;
        }

        private bool ejecutar(string sql)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException err)
            {
                MessageBox.Show($"Ocurrio un error: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public bool insertar(object objDatos)
        {
            ClsPrestamo pre = new ClsPrestamo();
            pre = (ClsPrestamo)objDatos;

            // Inserta datos en la tabla usuarios
            string sql = "EXEC InsertarPrestamo @Usuario, @FechaPrestamo, Pendiente";

            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Asegúrate de ajustar el tipo de datos y tamaño según tu base de datos
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pre.Usuario;
                    cmd.Parameters.Add("@FechaPrestamo", SqlDbType.DateTime).Value = pre.FechaPrestamo;
                    // Agrega más parámetros según sea necesario

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException err)
                    {
                        MessageBox.Show($"Ocurrió un error: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool modificar(object objDatos)
        {
            ClsPrestamo pre = new ClsPrestamo();
            pre = (ClsPrestamo)objDatos;
            string sql = "UPDATE Prestamo SET FechaPrestamo='"+pre.FechaPrestamo+"' WHERE CodigoPrestamo="+pre.CodigoPrestamo+"";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool eliminar(string codPrestamo)
        {
            string sql = "DELETE FROM Prestamo WHERE CodigoPrestamo="+codPrestamo+"";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public DataTable buscar(string campo, string valorCampo)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = GetConnection();

            string sql = "";

            // Código para buscar por id
            if (campo == "CodigoPrestamo")
            {
                sql = "SELECT P.CodigoPrestamo, U.UserName AS Usuario, CONVERT(VARCHAR(10), P.FechaPrestamo, 103) AS FechaPrestamoFormateada, P.Total " +
                    "FROM Prestamo P " +
                    "INNER JOIN Usuarios U ON P.Usuario = U.CodigoUser " +
                    "WHERE CodigoPrestamo = @valorCampo";
            }
            else if (campo == "Usuario")
            {
                sql = "SELECT P.CodigoPrestamo, U.UserName AS Usuario, CONVERT(VARCHAR(10), P.FechaPrestamo, 103) AS FechaPrestamoFormateada, P.Total " +
                    "FROM Prestamo P " +
                    "INNER JOIN Usuarios U ON P.Usuario = U.CodigoUser " +
                    $"WHERE U.UserName LIKE '%{valorCampo}%'";
            }
            else if (campo == "FechaPrestamo")
            {
                // Asegúrate de que valorCampo sea una fecha en el formato correcto 'DD-MM-AAAA'
                sql = "SELECT P.CodigoPrestamo, U.UserName AS Usuario, CONVERT(VARCHAR(10), P.FechaPrestamo, 103) AS FechaPrestamoFormateada, P.Total " +
                    "FROM Prestamo P " +
                    "INNER JOIN Usuarios U ON P.Usuario = U.CodigoUser " +
                    "WHERE P.FechaPrestamo = CONVERT(DATE, @valorCampo, 103)";
            }

            try
            {
                con.Open();

                // Usar SqlCommand con parámetros
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@valorCampo", valorCampo);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            catch (SqlException error)
            {
                MessageBox.Show($"Error al buscar un registro: {error.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return data;
        }
    }
}
