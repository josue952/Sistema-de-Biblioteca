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
    class LibroDao: ConnectionDataBase
    {
        public DataTable consultarCat(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM libros";
            if (tabla == "listaCategorias")
            {
                sql = "select CodigoCategoria, NombreCategoria from Categoria";

            }
            else
            {
                sql = "select * from v_libros";
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
        public DataTable consultarAu(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM libros";
            if (tabla == "listaAutores")
            {
                sql = "select CodigoAutor, NombreAutor from Autores";

            }
            else
            {
                sql = "select * from v_libros";
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
        public DataTable consultarEd(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM libros";
            if (tabla == "listaEditorial")
            {
                sql = "select CodigoEditorial, NombreEditorial from Editorial";

            }
            else
            {
                sql = "select * from v_libros";
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
            ClsLibro libro = new ClsLibro();
            libro = (ClsLibro)datos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Libros VALUES('"+libro.CodigoLibro+"','"+libro.Nombre+"',"+libro.CodAutor+","+libro.CodEditorial+","+libro.CodCategoria+","+libro.Stock+","+libro.Precio+",'"+libro.Estado+"')";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool modificar(object datos)
        {
            ClsLibro libro = new ClsLibro();
            libro = (ClsLibro)datos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Libros SET ISBN='"+libro.CodigoLibro+"', NombreLibro='"+libro.Nombre+"', Autor="+libro.CodAutor+", Editorial="+libro.CodEditorial+", Categoria="+libro.CodCategoria+", StockLibro="+libro.Stock+", PrecioLibro="+libro.Precio+", EstadoLibro='"+libro.Estado+"' WHERE ISBN='"+libro.CodigoLibro+"'";
            if (ejecutar(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminar(string cod)
        {
            string sql = "DELETE FROM Libros WHERE ISBN='" + cod + "'";
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
            if (campo == "ISBN")
            {
                sql = "SELECT  * FROM v_libros WHERE ISBN=" + valorCampo;

            }else if(campo == "Titulo")
            {
                sql = "SELECT  * FROM v_libros WHERE NombreLibro=" + valorCampo;
            }
            else if (campo == "Autor")
            {
                sql = "SELECT  * FROM v_libros WHERE NombreAutor=" + valorCampo;
            }
            else if (campo == "Categoria")
            {
                sql = "SELECT  * FROM v_libros WHERE NombreCategoria=" + valorCampo;
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
