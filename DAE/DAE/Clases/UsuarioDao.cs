using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DAE.Clases;
using DAE.DAO;

namespace DAE.DAO
{
    class UsuarioDao: ConnectionDataBase
    {
        //string sql = "";
        //SqlCommand cmd = new SqlCommand();
        //ClsUsuario us = new ClsUsuario();
       

        public DataTable consultar()
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM Usuarios";
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

        public bool insertar(object objDatos)
        {
            ClsUsuario us = new ClsUsuario();
            us = (ClsUsuario)objDatos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Usuarios VALUES('"+us.Usuario+"','"+us.Contra+"','"+us.Rol+ "')";
            if (ejecutar(sql))
            {
                return true;
            }else { return false; }
        }

        public bool modificar(object objDatos)
        {
            ClsUsuario us = new ClsUsuario();
            us = (ClsUsuario)objDatos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Usuarios SET Username = '"+us.Usuario+"', UserPassword = '"+us.Contra+"', UserRol = '"+us.Rol+ "', UserDepartamento = '" + us.Departamento+"' WHERE CodigoUser = " + us.UserId;
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
                sql = "SELECT * FROM Usuarios WHERE "+campo+" LIKE '%"+valorCampo+"%'";
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

        public bool Login(string user, string pass)
        {
            SqlConnection con = GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //definir parametros para la sql
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Usuarios WHERE UserName = @user AND UserPassword = @pass";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //set de datos a los atributos de la clase UserLoginCache
                        UserLoginCache.idUser = reader.GetInt32(0);
                        UserLoginCache.userName = reader.GetString(1);
                        UserLoginCache.rolUser = reader.GetString(3);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch  (SqlException err)
            {
                MessageBox.Show($"Error al extraer la sesion: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
