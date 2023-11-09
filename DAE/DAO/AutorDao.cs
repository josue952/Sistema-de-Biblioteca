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
    class AutorDao: ConnectionDataBase
    {

        public DataTable consultar(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM v_autores";
            if (tabla == "listaCategorias")
            {
                sql = "select CodigoCategoria, NombreCategoria from Categoria";

            }
            else
            {
                sql = "select * from v_autores";
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
            ClsAutor au = new ClsAutor();
            au = (ClsAutor)datos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Autores VALUES('"+au.Nombre+"',"+au.Categoria+")";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool modificar(object datos)
        {
            ClsAutor au = new ClsAutor();
            au = (ClsAutor)datos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Autores SET NombreAutor='"+au.Nombre+"', CodCategoria="+au.Categoria+" WHERE CodigoAutor="+au.Codigo;
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
            string sql = "DELETE FROM Autores WHERE CodigoAutor='" + cod + "'";
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
            if (campo == "CodigoAutor")
            {
                sql = "SELECT  * FROM v_autores WHERE CodigoAutor=" + valorCampo;

            }
            else
            {
                sql = "select * from v_autores where " + campo + " like '%" + valorCampo + "%'";
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
