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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();

            // Configura el formato del DateTimePicker
            dateFechaCompra.Format = DateTimePickerFormat.Custom;
            dateFechaCompra.CustomFormat = "dd/MM/yyyy";
            txtUsuario.Text = UserLoginCache.userName;
            txtCodigoCompras.Text = "0";
            if (UserLoginCache.rolUser == "Bibliotecario")
            {
                btnEliminarCom.Enabled = false;
                btnEliminarItenDB.Enabled = false;
            }
        }
        ClsCompras obj = new ClsCompras();
        private List<ClsDetalleCompra> detallesCompra = new List<ClsDetalleCompra>();

        private void cargar()//carga los datos de la tabla compras
        {
            dtTablaCompras.DataSource = obj.getDatos("Compras");
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

        private void frmCompras_Load(object sender, EventArgs e)
        {
            listarLibros();
            listarCategoria();
            cargar();
        }
        private void btnAgregarCom_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Usuario = txtUsuario.Text;
                obj.FechaCompra = dateFechaCompra.Value;
                obj.insertarDatos(obj);
                limpiarCampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al insertar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCom_Click(object sender, EventArgs e)
        {
            if (txtCodigoCompras.Text != "")
            {
                try
                {
                    obj.CodigoCompra = int.Parse(txtCodigoCompras.Text);
                    obj.FechaCompra = dateFechaCompra.Value;
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

        private void btnEliminarCom_Click(object sender, EventArgs e)
        {
                if (txtCodigoCompras.Text != "")
                {
                    string mensaje = "Seguro que desea eliminar?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Question;
                    DialogResult result = MessageBox.Show(mensaje, "Eliminando", buttons, icon);
                    if (result == DialogResult.Yes)
                    {
                        obj.eliminarDatos(txtCodigoCompras.Text);
                        cargar();
                        limpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtBuscarCompras.Text != "" && cmbPorCompras.Text != "")
            {
                string campo;
                if (cmbPorCompras.Text == "CodigoCompra")
                {
                    campo = "CodigoCompra";
                }
                else if (cmbPorCompras.Text == "Usuario")
                {
                    campo = "Usuario";
                }
                else
                {
                    campo = "FechaCompra";
                }
                dtTablaCompras.DataSource = obj.buscarRegistro(campo, txtBuscarCompras.Text);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios o incompletos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTableCom_Click(object sender, EventArgs e)
        {
            cargar();
        }


        private void dtTableDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtCodigoDetalleCompra.Text = dtTableDetalleCompra.CurrentRow.Cells[0].Value.ToString();
                this.cmbCategoria.Text = dtTableDetalleCompra.CurrentRow.Cells[1].Value.ToString();
                this.cmbLibros.Text = dtTableDetalleCompra.CurrentRow.Cells[2].Value.ToString();
                this.txtPrecio.Text = dtTableDetalleCompra.CurrentRow.Cells[3].Value.ToString();
                this.numCantidad.Text = dtTableDetalleCompra.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ClsDetalleCompra detalleTemporal = null;
        private void btnAgregarDetalleCom_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia(tabla) de la clase ClsDetalleCompra con los datos del detalle actual
                detalleTemporal = new ClsDetalleCompra
                {
                    NombreLibro = cmbLibros.Text,
                    Cantidad = int.Parse(numCantidad.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                };

                // Agregar el detalle a la lista de detalles de compra
                detallesCompra.Add(detalleTemporal);
                // Limpiar los campos después de agregar el detalle
                limpiarCamposDetalleCompra();
                // Mostrar los detalles de compra en el DataGridView DetalleCompras
                cargarDetallesCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cargarDetallesCompra()
        {
            dtTableDetalleCompra.DataSource = null;
            dtTableDetalleCompra.DataSource = detallesCompra;
        }

        private void limpiarCamposDetalleCompra()
        {
            txtCodigoDetalleCompra.Text = "";
            cmbLibros.SelectedIndex = -1;
            numCantidad.Value = 0;
            txtPrecio.Clear();
        }

        bool AgregarItemsClic = false;
        bool EliminarItemsBD = false;
        public void dtTablaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtCodigoCompras.Text = dtTablaCompras.CurrentRow.Cells[0].Value.ToString();
                this.txtUsuario.Text = dtTablaCompras.CurrentRow.Cells[1].Value.ToString();
                this.dateFechaCompra.Text = dtTablaCompras.CurrentRow.Cells[2].Value.ToString();
                this.txtTotal.Text = dtTablaCompras.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                codigoCompraActual = int.Parse(txtCodigoCompras.Text);
                ClsDetalleCompra detalleCompra = new ClsDetalleCompra();
                // Obtener los detalles de compra asociados al código de compra seleccionado
                DataTable dtDetallesCompra = detalleCompra.getDetallesCompra(codigoCompraActual);
                // Mostrar los detalles de compra en el DataGridView dtTableDetalleCompra
                dtTableDetalleCompra.DataSource = dtDetallesCompra;
                cmbCategoria.Enabled = false;
                cmbLibros.Enabled = false;
                txtPrecio.Enabled = false;
                numCantidad.Enabled = false;
                limpiarCamposDetalleCompra();
                AgregarItemsClic = true;
                btnAgregarItemsCom.Enabled = true;
                EliminarItemsBD = true;
                btnEliminarItenDB.Enabled = true;

            }
        }
        LibroDB libro = new LibroDB("");
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

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
            try
            {
                if (detallesCompra.Count == 0 || numCantidad.Value == 0)
                {
                    MessageBox.Show("Debe agregar al menos un item o cantidad al detalle antes de guardar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del método si no hay detalles de compra
                }

                // Inserta datos en la tabla DetalleCompras utilizando parámetros
                string insertDetalleQuery = "EXEC InsertarDetalleCompra @CodigoCompra, @Libro, @PrecioLibro, @Cantidad, @SubTotal";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        foreach (ClsDetalleCompra detalleCompra in detallesCompra)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertDetalleQuery, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@CodigoCompra", codigoCompraActual);
                                cmd.Parameters.AddWithValue("@Libro", detalleCompra.NombreLibro);
                                cmd.Parameters.AddWithValue("@PrecioLibro", detalleCompra.Precio);
                                cmd.Parameters.AddWithValue("@Cantidad", detalleCompra.Cantidad);
                                cmd.Parameters.AddWithValue("@SubTotal", detalleCompra.SubTotal);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        // Confirma la transacción si todo es exitoso
                        transaction.Commit();
                        // Limpiar la lista de detalles de compra después de guardar
                        detallesCompra.Clear();
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
                        ClsDetalleCompra detalleCompra = new ClsDetalleCompra();
                        // Obtener los detalles de compra asociados al código de compra seleccionado
                        DataTable dtDetallesCompra = detalleCompra.getDetallesCompra(codigoCompraActual);
                        // Mostrar los detalles de compra en el DataGridView dtTableDetalleCompra
                        dtTableDetalleCompra.DataSource = dtDetallesCompra;

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al guardar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int codigoCompraActual; // Variable para almacenar el código de la compra actual
        private void btbAgregarItemsCom_Click(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = true;
            cmbLibros.Enabled = true;
            numCantidad.Enabled = true;
            EliminarItemsBD = false;
        }
        private void dateFechaCompra_ValueChanged(object sender, EventArgs e)
        {
            // Verificar si la opción seleccionada en cmbPorCompras es "FechaCompra"
            if (cmbPorCompras.Text == "FechaCompra")
            {
                // Actualizar el contenido de txtBuscarCompras con la fecha formateada
                txtBuscarCompras.Text = dateFechaCompra.Value.ToString("dd/MM/yyyy");
            }
        }
        private void cmbPorCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPorCompras.Text == "FechaCompra")
            {
                // Configurar el formato del DateTimePicker para mostrar solo la fecha
                dateFechaCompra.Format = DateTimePickerFormat.Custom;
                dateFechaCompra.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                // Restaurar el formato predeterminado si la opción seleccionada no es "FechaCompra"
                dateFechaCompra.Format = DateTimePickerFormat.Short;
            }
        }

        private void btnElminarIten_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay un detalle temporal
                if (detalleTemporal != null)
                {
                    // Eliminar el detalle temporal
                    detallesCompra.Remove(detalleTemporal);
                    detalleTemporal = null; // Limpiar la variable temporal

                    // Limpiar los campos después de eliminar el detalle
                    limpiarCamposDetalleCompra();
                    // Mostrar los detalles de compra en el DataGridView DetalleCompras
                    cargarDetallesCompra();
                }
                else
                {
                    MessageBox.Show("No hay un detalle temporal para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarItenDB_Click(object sender, EventArgs e)
        {
            if (EliminarItemsBD == true)
            {
                if (cmbCategoria.Text != "")
                {
                    string mensaje = "Seguro que desea eliminar?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Question;
                    DialogResult result = MessageBox.Show(mensaje, "Eliminando", buttons, icon);

                    if (result == DialogResult.Yes)
                    {
                        // Configurar la cadena de conexión a tu base de datos
                        string connectionString = "Server=sistemabiblioteca.database.windows.net; Initial Catalog=Sistema de Biblioteca; Persist Security Info=False; User ID=josue; Password=Biblioteca123$; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";

                        // Crear una conexión a la base de datos
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                // Abrir la conexión
                                connection.Open();

                                // Configurar el comando SQL para ejecutar el procedimiento almacenado
                                using (SqlCommand command = new SqlCommand("EliminarDetalleCompra", connection))
                                {
                                    // Especificar que es un procedimiento almacenado
                                    command.CommandType = CommandType.StoredProcedure;

                                    // Agregar el parámetro para el código de detalle de compra
                                    command.Parameters.AddWithValue("@CodigoDetalleCompra", int.Parse(txtCodigoDetalleCompra.Text));

                                    // Ejecutar el procedimiento almacenado
                                    command.ExecuteNonQuery();

                                    // Mensaje de éxito
                                    MessageBox.Show("Detalle de compra eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al eliminar detalle de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                // Cerrar la conexión después de usarla
                                connection.Close();

                                // Actualizar la interfaz después de la eliminación
                                cargar();
                                limpiarCampos();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacíos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada
            string categoriaSeleccionada = cmbCategoria.Text;

            // Obtiene el nombre del libro seleccionado
            string nombreLibroSeleccionado = cmbLibros.Text;

            // Crea una instancia de la clase LibroDB y obtiene los precios de los libros
            LibroDB libroDB = new LibroDB("");
            List<LibroDB> preciosLibros = libroDB.GetPrecios(categoriaSeleccionada, nombreLibroSeleccionado);

            // Asigna el precio del primer libro si hay alguno
            if (preciosLibros.Count > 0)
            {
                txtPrecio.Text = preciosLibros[0].precioLibro.ToString();
            }
            else
            {
                // Si no hay precios de libros, limpia el TextBox de precio
                txtPrecio.Text = "";
            }
        }
    }
}

