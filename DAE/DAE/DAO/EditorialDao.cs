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
    class EditorialDao : ConnectionDataBase
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
            Sql = "select * from Editorial";
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
            ClsEditorial ed = new ClsEditorial();
            ed = (ClsEditorial)datos;
            string sql = "INSERT INTO Editorial VALUES('"+ed.Nombre+"','"+ed.Correo+"','"+ed.Direccion+"','"+ed.Telefono+"')";
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
            ClsEditorial ed = new ClsEditorial();
            ed = (ClsEditorial)datos;
            string sql = "UPDATE Editorial SET NombreEditorial='"+ed.Nombre+"', CorreoEditorial='"+ed.Correo+"', DireccionEditorial='"+ed.Direccion+"', NumeroEditorial='"+ed.Telefono+"'  WHERE CodigoEditorial='"+ed.CodigoEditorial+"'";

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
            string sql = "delete from Editorial where CodigoEditorial=" + codigo;

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

            if (campo == "CodigoEditorial")
            {
                Sql = "select * from Editorial where CodigoEditorial=" + valorCampo;
            }
            else
            {
                Sql = "select * from Editorial where " + campo + " like '%" + valorCampo + "%'";
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
