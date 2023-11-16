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
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
            // Configura el formato del DateTimePicker
            dateFechaPrestamo.Format = DateTimePickerFormat.Custom;
            dateFechaPrestamo.CustomFormat = "dd/MM/yyyy";
            txtUsuario.Text = UserLoginCache.userName;
            txtCodigoPrestamo.Text = "0";
        }
        ClsPrestamo obj = new ClsPrestamo();
        private List<ClsDetallePrestamo> detallesPrestamo = new List<ClsDetallePrestamo>();
        private void cargar()//carga los datos de la tabla compras
        {
            dtPrestamo.DataSource = obj.getDatos("Prestamos");
        }
        private void listarLibros()
        {
            cmbLibros.DisplayMember = "NombreLibro";
            cmbLibros.ValueMember = "ISBN";
            cmbLibros.DataSource = obj.getDatos("listaLibros");
        }

        private void listarCategoria()
        {
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "CodigoCategoria";
            cmbCategoria.DataSource = obj.getDatos("listaCategorias");
        }
        private void limpiarCampos()
        {
            listarLibros();
            listarCategoria();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            listarLibros();
            listarCategoria();
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Usuario = txtUsuario.Text;
                obj.FechaPrestamo = dateFechaPrestamo.Value;
                obj.insertarDatos(obj);
                limpiarCampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al insertar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigoPrestamo.Text != "")
            {
                try
                {
                    obj.CodigoPrestamo = int.Parse(txtCodigoPrestamo.Text);
                    obj.FechaPrestamo = dateFechaPrestamo.Value;
                    obj.modificarDatos(obj);
                    limpiarCampos();
                    cargar();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Error al modificar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoPrestamo.Text != "")
            {
                string mensaje = "Seguro que desea eliminar?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(mensaje, "Eliminando", buttons, icon);
                if (result == DialogResult.Yes)
                {
                    obj.eliminarDatos(txtCodigoPrestamo.Text);
                    cargar();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTablePre_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void dtDetallePrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtCodigoDetallePrestamo.Text = dtDetallePrestamo.CurrentRow.Cells[0].Value.ToString();
                this.cmbCategoria.Text = dtDetallePrestamo.CurrentRow.Cells[1].Value.ToString();
                this.cmbLibros.Text = dtDetallePrestamo.CurrentRow.Cells[2].Value.ToString();
                this.numCantidad.Text = dtDetallePrestamo.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarItems_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtStockDisponible.Text)==0)
            {
                MessageBox.Show("Este libro no se encuentra disponible!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numCantidad.Value > int.Parse(txtStockDisponible.Text))
            {
                MessageBox.Show("Este prestamo supera al stock disponible!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Crear una instancia de la clase ClsDetalleCompra con los datos del detalle actual
                    ClsDetallePrestamo detalle = new ClsDetallePrestamo
                    {
                        NombreLibro = cmbLibros.Text,
                        Cantidad = int.Parse(numCantidad.Text),
                    };

                    // Agregar el detalle a la lista de detalles de compra
                    detallesPrestamo.Add(detalle);
                    // Limpiar los campos después de agregar el detalle
                    limpiarCamposDetallePrestamo();
                    // Mostrar los detalles de compra en el DataGridView DetalleCompras
                    cargarDetallesPrestamo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cargarDetallesPrestamo()
        {
            dtDetallePrestamo.DataSource = null;
            dtDetallePrestamo.DataSource = detallesPrestamo;
        }

        private void limpiarCamposDetallePrestamo()
        {
            txtCodigoDetallePrestamo.Text = "";
            cmbLibros.SelectedIndex = -1;
            numCantidad.Value = 0;
        }

        bool AgregarItemsClic = false;

        private int codigoPrestamoActual;
        public void dtPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtCodigoPrestamo.Text = dtPrestamo.CurrentRow.Cells[0].Value.ToString();
                this.txtUsuario.Text = dtPrestamo.CurrentRow.Cells[1].Value.ToString();
                this.dateFechaPrestamo.Text = dtPrestamo.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asignar el código del préstamo actual
                codigoPrestamoActual = int.Parse(txtCodigoPrestamo.Text);


                ClsDetallePrestamo detallePrestamo = new ClsDetallePrestamo();
                // Obtener los detalles de compra asociados al código de compra seleccionado
                DataTable dtDetalleDePrestamo = detallePrestamo.getDetallesPrestamo(codigoPrestamoActual);
                // Mostrar los detalles de compra en el DataGridView dtTableDetalleCompra
                dtDetallePrestamo.DataSource = dtDetalleDePrestamo;

                // Habilitar controles para agregar detalles
                cmbCategoria.Enabled = false;
                cmbLibros.Enabled = false;
                numCantidad.Enabled = false;
                limpiarCamposDetallePrestamo();
                AgregarItemsClic = true;
                btnAgregarItemsPre.Enabled = true;
            }

        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada
            string categoriaSeleccionada = cmbCategoria.Text;

            // Crear una instancia de la clase LibroDB y obtener los nombres de los libros
            LibroDB libroDB = new LibroDB("");
            List<LibroDB> libros = libroDB.GetNombreLibro(categoriaSeleccionada);

            // Desvincula temporalmente el DataSource para evitar el error
            cmbLibros.DataSource = null;

            // Configura la propiedad DisplayMember para indicar la propiedad que se mostrará
            cmbLibros.DisplayMember = "nombreLibro";

            // Configura la propiedad DataSource del ComboBox de libros
            cmbLibros.DataSource = libros;

            // Selecciona el primer libro si hay alguno
            if (libros.Count > 0)
            {
                cmbLibros.SelectedIndex = 0;
            }
            else
            {
                // Si no hay libros, limpia el ComboBox de libros
                cmbLibros.Text = "";
            }

        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";

            try
            {
                if (detallesPrestamo.Count == 0)
                {
                    MessageBox.Show("Debe ingresar almenos un item!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del método si no hay detalles de compra
                }

                // Inserta datos en la tabla DetalleCompras utilizando parámetros
                string insertDetalleQuery = "EXEC InsertarDetallePrestamo @CodigoPrestamo, @Libro, @Cantidad";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        foreach (ClsDetallePrestamo detallePrestamo in detallesPrestamo)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertDetalleQuery, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@CodigoPrestamo", codigoPrestamoActual);
                                cmd.Parameters.AddWithValue("@Libro", detallePrestamo.NombreLibro);
                                cmd.Parameters.AddWithValue("@Cantidad", detallePrestamo.Cantidad);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Confirma la transacción si todo es exitoso
                        transaction.Commit();

                        // Limpiar la lista de detalles de compra después de guardar
                        detallesPrestamo.Clear();

                        MessageBox.Show("Detalles de compra guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Ocurrió un error, realiza un rollback de la transacción
                        transaction.Rollback();
                        MessageBox.Show($"Error al guardar los detalles de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ClsDetallePrestamo detallePrestamo = new ClsDetallePrestamo();
                        // Obtener los detalles de compra asociados al código de compra seleccionado
                        DataTable dtDetalleDePrestamo = detallePrestamo.getDetallesPrestamo(codigoPrestamoActual);
                        // Mostrar los detalles de compra en el DataGridView dtTableDetalleCompra
                        dtDetallePrestamo.DataSource = dtDetalleDePrestamo;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al guardar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarItemsPre_Click(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = true;
            cmbLibros.Enabled = true;
            numCantidad.Enabled = true;
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cmbCategoria.Text;
            string nombreLibro = cmbLibros.Text;

            //Crear una instancia de la clase LibroDB y obtener los Stocks de los libros
            LibroDB libroDB = new LibroDB("");
            List<LibroDB> stockLibros = libroDB.GetStock(categoriaSeleccionada, nombreLibro);

            // Muestra el stock en el TextBox
            if (stockLibros.Count > 0)
            {
                txtStockDisponible.Text = stockLibros[0].stockLibro.ToString();
            }
            else
            {
                // Manejar el caso en que no se encuentre el libro
                txtStockDisponible.Text = "No disponible";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
