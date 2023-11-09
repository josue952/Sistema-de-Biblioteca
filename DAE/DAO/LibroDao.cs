using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAE.Clases;
using DAE.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAE.DAO
{
    class LibroDao : ConnectionDataBase
    {
        public DataTable consultar(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM v_libros";
            if (tabla == "listaCategorias")
            {
                sql = "select CodigoCategoria, NombreCategoria from Categoria";

            }
            else
            {
                sql = "select*from v_libros";
            }

            if (tabla == "listaAutores")
            {
                sql = "select CodigoAutor, NombreAutor from Autores";

            }
            else
            {
                sql = "select*from v_libros";
            }
            if (tabla == "listaEditorial")
            {
                sql = "select CodigoEditorial, NombreEditorial from Editorial";

            }
            else
            {
                sql = "select*from v_libros";
            }
            SqlConnection con = GetConnection();//extaer conexion
            try
            {
                con.Open();//abrir la conexion
                string connectionString = getConnectionString();//extaer caneda de conexion
                adapter = new SqlDataAdapter(sql, connectionString);//ejecutar consulta
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



        public bool insertar(object datos)
        {
            ClsLibro li = new ClsLibro();
            li = (ClsLibro)datos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Libros VALUES('"+li.CodigoLibro+"','"+li.NombreLibro+"',"+li.Autor+","+li.Editorial+","+li.Categoria+","+li.Stock+","+li.Precio+",'"+li.EstadoLibro+"')";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool modificar(object datos)
        {
            ClsLibro li = new ClsLibro();
            li = (ClsLibro)datos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Libros SET NombreLibro='"+li.NombreLibro+"', Autor="+li.Autor+", Editorial="+li.Editorial+", Categoria="+li.Categoria+", StockLibro="+li.Stock+", PrecioLibro="+li.Precio+", EstadoLibro='"+li.EstadoLibro+"' WHERE ISBN ='"+li.CodigoLibro+"'";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool eliminar(string cod)
        {
            string sql = "DELETE FROM Libros WHERE ISBN='"+cod + "'";
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
            SqlConnection con = GetConnection();//extaer conexion
            string sql = "";
            //codigo para buscar por id
            if (campo == "CodigoLibro")
            {
                sql = "SELECT  * FROM v_libros WHERE ISBN=" + valorCampo;

            }
            else
            {
                sql = "select * from v_libros where " + campo + " like '%" + valorCampo + "%'";
            }

            try
            {
                con.Open();//abrir la conexion
                string connectionString = getConnectionString();//extaer caneda de conexion
                adapter = new SqlDataAdapter(sql, connectionString);//ejecutar consulta
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


