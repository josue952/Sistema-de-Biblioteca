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
    class CategoriaDao: ConnectionDataBase
    {
        private string sql;

        //string Sql = "";
        //SqlCommand cmd = new SqlCommand();
        //ClsUsuario us = new ClsUsuario();
        public DataTable consultar()
        {
            string Sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            Sql = "select * from Categoria";
            SqlConnection con = GetConnection(); //extraer conexion
            try
            {

                con.Open();//abrir la conexion
                string connectionString = getConnectionString();//ejecutar la consulta
                adapter = new SqlDataAdapter(Sql, connectionString);//ejecutar consulta
                adapter.Fill(datos);

            }
            catch (SqlException error)
            {
                MessageBox.Show("ocurrio el siguiente error :" + error.Message, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
            return datos;
        }


        private bool ejecutar(string sql)
        {
            SqlConnection con = GetConnection(); //extraer conexion
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
                MessageBox.Show("ocurrio un error:" + err.Message, "INFORMACION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public bool insertar(object datos)
        {
            ClsCategoria cat = new ClsCategoria();
            cat = (ClsCategoria)datos;
            string sql = "INSERT INTO Categoria VALUES('"+cat.Nombre+"','"+cat.Descripcion+"')";
            if (ejecutar(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar(object datos)
        {
            ClsCategoria cat = new ClsCategoria();
            cat = (ClsCategoria)datos;
            string sql = "UPDATE Categoria SET NombreCategoria='"+cat.Nombre+"', DescripcionCategoria='"+cat.Descripcion+"' WHERE CodigoCategoria="+cat.Codigo;

            if (ejecutar(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool eliminar(object codigo)//estrin o tipo entero
        {
            string sql = "delete from Categoria where CodigoCategoria=" + codigo;

            if (ejecutar(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable buscar(string campo, string valorCampo)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = GetConnection(); // Extraer la conexión
            string Sql = "";

            if (campo == "CodigoCategoria")
            {
                Sql = "select * from Categoria where CodigoCategoria=" + valorCampo;
            }
            else
            {
                Sql = "select * from Categoria where " + campo + " like '%" + valorCampo + "%'";
            }

            try
            {
                con.Open(); // Abrir la conexión
                string connectionString = getConnectionString();
                adapter = new SqlDataAdapter(Sql, connectionString);
                adapter.Fill(data);
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error al buscar un registro: " + error.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return data;
        }
    }
}

