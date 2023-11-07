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
        
        public DataTable consultar()
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //
            //muestra todos los usuarios
            SqlConnection con = GetConnection();//extaer conexion
            frmCompras frm = new frmCompras();
            string sql = "";
            sql = frm.consulta;
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

        public bool insertar(object objDatos)
        {
            ClsUsuario us = new ClsUsuario();
            us = (ClsUsuario)objDatos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Usuarios VALUES('" + us.Usuario + "','" + us.Contra + "','" + us.Rol + "','" + us.Departamento + "')";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool modificar(object objDatos)
        {
            ClsUsuario us = new ClsUsuario();
            us = (ClsUsuario)objDatos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Usuarios SET Username = '" + us.Usuario + "', UserPassword = '" + us.Contra + "', UserRol = '" + us.Rol + "', UserDepartamento = '" + us.Departamento + "' WHERE CodigoUser = " + us.UserId;
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool eliminar(string codUsuario)
        {
            string sql = "DELETE FROM Usuarios WHERE CodigoUser =" + codUsuario;
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
            if (campo == "UserId")
            {
                sql = "SELECT * FROM Usuarios WHERE CodigoUser =" + valorCampo;

            }
            else
            {
                sql = "SELECT * FROM Usuarios WHERE " + campo + " LIKE '%" + valorCampo + "%'";
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
