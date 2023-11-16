using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAE.Interfaz
{
    public partial class frmMulta : Form
    {
        public frmMulta()
        {
            InitializeComponent();
        }
        public string usuarioPrestamoActual;
        private void Multa_Load(object sender, EventArgs e)
        {
           frmListPrestamos frm = new frmListPrestamos();
            txtCodigoPrestamo.Text = int.;
            usuarioPrestamoActual = Convert.ToString(frm.usuarioPrestamoActual);
            txtCodigoPrestamo.Text = Convert.ToString(frm.fechaPrestamoActual);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Comienza la transacción
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        frmListPrestamos frm = new frmListPrestamos();
                        // Inserta datos en la tabla DetalleCompras utilizando parámetros
                        string insertDetalleQuery = $"INSERT INTO Multa VALUES ({frm.codigoPrestamoActual}, {Convert.ToDecimal(txtCosto)}, {frm.fechaPrestamoActual}, Pendiente)";

                        using (SqlCommand cmd = new SqlCommand(insertDetalleQuery, con, transaction))
                        {
                            // Ejecuta la consulta SQL
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Confirma la transacción si todo es exitoso
                            transaction.Commit();

                            MessageBox.Show($"Se agrego una multa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Ocurrió un error, realiza un rollback de la transacción
                        transaction.Rollback();
                        MessageBox.Show($"Error al agregar multa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
