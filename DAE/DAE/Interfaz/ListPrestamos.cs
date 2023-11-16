using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAE.Interfaz;
using DAE.Clases;
using DAE.DAO;
using System.Data.SqlClient;

namespace DAE.Interfaz
{
    public partial class frmListPrestamos : Form
    {
        public frmListPrestamos()
        {
            InitializeComponent();
        }
        ClsPrestamo obj = new ClsPrestamo();
        private int idPrestamoSeleccionado;
        private void cargar()//carga los datos de la tabla compras
        {
            dtListadoPrestamos.DataSource = obj.getDatos("Prestamos");
            
            dtListadoPrestamos.Refresh();

        }

        private void frmListPrestamos_Load(object sender, EventArgs e)
        {
            cargar();
            dtListadoPrestamos.CellClick += dtListadoPrestamos_CellClick;
            dtListadoPrestamos.SelectionChanged += dtListadoPrestamos_SelectionChanged;
        }

        public int codigoPrestamoActual;
        public string usuarioPrestamoActual;
        public string fechaPrestamoActual;
        private void dtListadoPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtListadoPrestamos.Rows[e.RowIndex];
            idPrestamoSeleccionado = Convert.ToInt32(selectedRow.Cells["CodigoPrestamo"].Value);
        }
        private void dtListadoPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtListadoPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtListadoPrestamos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtListadoPrestamos.SelectedRows[0];
                int idPrestamo = Convert.ToInt32(selectedRow.Cells["CodigoPrestamo"].Value);
                codigoPrestamoActual = idPrestamo;
                string usuaio = Convert.ToString(selectedRow.Cells["NombreUsuario"].Value);
                usuarioPrestamoActual = usuaio;
                string fecha = Convert.ToString(selectedRow.Cells["FechaPrestamo"].Value);
                fechaPrestamoActual = fecha;

                ClsDetallePrestamo detalleDelPrestamo = new ClsDetallePrestamo();
                // Obtener los detalles de compra asociados al código de compra seleccionado
                DataTable dtDetalleDePrestamo = detalleDelPrestamo.getDetallesPrestamo(codigoPrestamoActual);
                // Mostrar los detalles de compra en el DataGridView dtTableDetalleCompra
                dtListDetallePrestamo.DataSource = dtDetalleDePrestamo;
            }
        }
        private void dtListDetallePrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                string mensaje = "seguro que desea eliminar el contenido?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(mensaje, "ELIMINANDO", buttons, icon);
                if (result == DialogResult.Yes)
                {
                    obj.eliminarDatos(Convert.ToString(codigoPrestamoActual));
                    cargar();
                }
        }

        private void btnAgregarMulta_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado > 0)
            {
                // Crea una instancia del formulario pequeño
                
                frmMulta formularioPequeno = new frmMulta();

                // Muestra el formulario pequeño
                formularioPequeno.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un préstamo antes de asignar una multa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAprobarPrestamo_Click(object sender, EventArgs e)
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
                        // Inserta datos en la tabla DetalleCompras utilizando parámetros
                        string insertDetalleQuery = $"UPDATE Prestamo SET Estado = 'Aprobado' WHERE CodigoPrestamo = {codigoPrestamoActual};";

                        using (SqlCommand cmd = new SqlCommand(insertDetalleQuery, con, transaction))
                        {
                            // Ejecuta la consulta SQL
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Confirma la transacción si todo es exitoso
                            transaction.Commit();

                            MessageBox.Show($"Se aprobaron {rowsAffected} prestamos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Ocurrió un error, realiza un rollback de la transacción
                        transaction.Rollback();
                        MessageBox.Show($"Error al aprobar el prestamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
