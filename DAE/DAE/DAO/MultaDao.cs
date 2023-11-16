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
    class MultaDao : ConnectionDataBase
    {
        public DataTable consultar(string tabla)
        {
            string sql = "";
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //muestra todos los usuarios
            sql = "SELECT * FROM v_multa";
            if (tabla == "listaMultas")
            {
                sql = "select  from Multa";

            }
            else
            {
                sql = "select * from v_multa";
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
            ClsMulta mu = new ClsMulta();
            mu = (ClsMulta)datos;
            //Inserta datos en la tabla usuarios
            string sql = "INSERT INTO Multa VALUES("+mu.CodigoPrestamo+","+mu.CostoMulta+",'"+mu.FechaMulta+"','"+mu.EstadoMulta+"')";
            if (ejecutar(sql))
            {
                return true;
            }
            else { return false; }
        }

        public bool modificar(object datos)
        {
            ClsMulta mu = new ClsMulta();
            mu = (ClsMulta)datos;
            //modifica el usuario segun su id(codigo)
            string sql = "UPDATE Multa SET EstadoMulta='"+mu.EstadoMulta+"' WHERE IdMulta="+mu.CodigoMulta;
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
            string sql = "DELETE FROM Multa WHERE IdMulta='" + cod + "'";
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
            if (campo == "CodigoMulta")
            {
                sql = "SELECT  * FROM v_multa WHERE IdMulta=" + valorCampo;

            }else if(campo == "CodigoPrestamo")
            {
                sql = "SELECT  * FROM v_multa WHERE idPrestamo=" + valorCampo;
            }
            else
            {
                sql = "select * from v_multa where " + campo + " like '%" + valorCampo + "%'";
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
