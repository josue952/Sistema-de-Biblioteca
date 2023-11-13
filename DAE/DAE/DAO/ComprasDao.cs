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
    internal class ComprasDao: ConnectionDataBase
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
                sql = "SELECT CodigoCompra, U.UserName AS Usuario,FechaCompra, Total FROM Compras C " +
                "INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser";
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
            ClsCompras com = new ClsCompras();
            com = (ClsCompras)objDatos;

            // Inserta datos en la tabla usuarios
            string sql = "EXEC InsertarCompra @Usuario, @FechaCompra, 0";

            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Asegúrate de ajustar el tipo de datos y tamaño según tu base de datos
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = com.Usuario;
                    cmd.Parameters.Add("@FechaCompra", SqlDbType.DateTime).Value = com.FechaCompra;
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
            ClsCompras com = new ClsCompras();
            com = (ClsCompras)objDatos;
            string sql = "UPDATE Compras SET FechaCompra = '"+com.FechaCompra+"' WHERE CodigoCompra = "+com.CodigoCompra+"";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool eliminar(string codCompra)
        {
            string sql = "DELETE FROM Compras WHERE CodigoCompra='" + codCompra + "'";
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
            if (campo == "CodigoCompra")
            {
                sql = "SELECT C.CodigoCompra, U.UserName AS Usuario, CONVERT(VARCHAR(10), C.FechaCompra, 103) AS FechaCompraFormateada, C.Total " +
                    "FROM Compras C " +
                    "INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser " +
                    "WHERE CodigoCompra = @valorCampo";
            }
            else if (campo == "Usuario")
            {
                sql = "SELECT C.CodigoCompra, U.UserName AS Usuario, CONVERT(VARCHAR(10), C.FechaCompra, 103) AS FechaCompraFormateada, C.Total " +
                    "FROM Compras C " +
                    "INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser " +
                    $"WHERE U.UserName LIKE '%{valorCampo}%'";
            }
            else if (campo == "FechaCompra")
            {
                // Asegúrate de que valorCampo sea una fecha en el formato correcto 'DD-MM-AAAA'
                sql = "SELECT C.CodigoCompra, U.UserName AS Usuario, CONVERT(VARCHAR(10), C.FechaCompra, 103) AS FechaCompraFormateada, C.Total " +
                    "FROM Compras C " +
                    "INNER JOIN Usuarios U ON C.Usuario = U.CodigoUser " +
                    "WHERE C.FechaCompra = CONVERT(DATE, @valorCampo, 103)";
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
