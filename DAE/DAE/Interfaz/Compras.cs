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

            // Suscribe el método al evento ValueChanged del DateTimePicker
            dateFechaCompra.ValueChanged += dateFechaCompra_ValueChanged;
        }
        ClsCompras obj = new ClsCompras();

        private void cargar()//carga los datos de la tabla compras
        {
            dtTablaCompras.DataSource = obj.getDatos("Compras");
        }
        private void listarUsuarios()
        {
            cmbUsuario.DisplayMember = "UserName";
            cmbUsuario.ValueMember = "CodigoUser";
            cmbUsuario.DataSource = obj.getDatos("listaUsuarios");
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
            listarUsuarios();
            listarLibros();
            listarCategoria();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            listarLibros();
            listarCategoria();
            cargar();
        }
        private void btnAgregarCom_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (cmbPorCompras.Text == "Libros")
                {
                    campo = "Libros";
                }
                else if (cmbPorCompras.Text == "Editorial")
                {
                    campo = "Editorial";
                }
                else if (cmbPorCompras.Text == "Usuario")
                {
                    campo = "Usuario";
                }
                else if (cmbPorCompras.Text == "CodigoCompra")
                {
                    campo = "CodigoCompra";
                }
                else if (cmbPorCompras.Text == "FechaCompra")
                {
                    campo = "FechaCompra";
                }
                else if (cmbPorCompras.Text == "CodigoCompraAgrupada")
                {
                    campo = "CodigoCompraAgrupada";
                }
                else if (cmbPorCompras.Text == "UsuarioAgrp")
                {
                    campo = "UsuarioAgrp";
                }
                else if (cmbPorCompras.Text == "FechaCompraAgrp")
                {
                    campo = "FechaCompraAgrp";
                }
                else
                {
                    campo = "";
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

        bool ComprasAgrpClick = false;

        private void dtTableDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarDetalleCom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se puede agregar un detalle de compra a una compra agrupada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dtTablaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigoCompras.Text = dtTablaCompras.CurrentRow.Cells[0].Value.ToString();
            this.cmbUsuario.Text = dtTablaCompras.CurrentRow.Cells[1].Value.ToString();
            this.dateFechaCompra.Text = dtTablaCompras.CurrentRow.Cells[2].Value.ToString();
            this.txtTotal.Text = dtTablaCompras.CurrentRow.Cells[3].Value.ToString();
        }
        LibroDB libro = new LibroDB("");
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada
            string categoriaSeleccionada = cmbCategoria.Text;

            // Crear una instancia de la clase LibroDB y obtener los nombres de los libros
            LibroDB libroDB = new LibroDB("");
            List<LibroDB> libros = libroDB.Get(categoriaSeleccionada);

            // Configura la propiedad DataSource del ComboBox de libros
            cmbLibros.DataSource = libros;

            // Configura la propiedad DisplayMember para indicar la propiedad que se mostrará
            cmbLibros.DisplayMember = "nombreLibro";

            // Selecciona el primer libro si hay alguno
            if (libros.Count > 0)
            {
                cmbLibros.SelectedIndex = 0;
            }
            else
            {
                // Si no hay libros, limpia el ComboBox de libros
                cmbLibros.DataSource = null;
            }
        }

        public void dateFechaCompra_ValueChanged(object sender, EventArgs e)
        {
        }



        /*public void btnVerCompUnit_Click(object sender, EventArgs e) //carga los datos de la tabla compras unitarias
        {
            btnAgregarCom.Enabled = true;
            btnEditarCom.Enabled = true;
            btnEliminarCom.Enabled = true;
            ComprasAgrpClick = false;
            //
            cmbPorCompras.Items.Clear();
            cmbPorCompras.Items.Add("CodigoCompra");
            cmbPorCompras.Items.Add("Libros");
            cmbPorCompras.Items.Add("Editorial");
            cmbPorCompras.Items.Add("Usuario");
            cmbPorCompras.Items.Add("FechaCompra");
            cargar("ComprasUnitarias");
        }
        public bool ComprasAgrpClick = false;
        public void btnVerCompAgrp_Click(object sender, EventArgs e)
        {
            ComprasAgrpClick = true;
            btnAgregarCom.Enabled = false;
            btnEditarCom.Enabled = false;
            btnEliminarCom.Enabled = false;
            //
            cmbPorCompras.Items.Clear();
            cmbPorCompras.Items.Add("CodigoCompraAgrupada");
            cmbPorCompras.Items.Add("UsuarioAgrp");
            cmbPorCompras.Items.Add("FechaCompraAgrp");
            cargar("ComprasAgrupadas");
        }
        
        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el libro y la editorial seleccionados
            string libroSeleccionado = cmbLibros.Text;
            string editorialSeleccionada = cmbEditorial.Text;

            // Crear una instancia de la clase LibroDB y obtener el precio del libro
            LibroDB libroDB = new LibroDB(0); // 0 es un valor ficticio para el precio inicial
            List<LibroDB> libros = libroDB.Get(libroSeleccionado, editorialSeleccionada);
        }

        if (libros.Count > 0)
        {
            // Actualiza el precio en el cuadro de texto txtPrecioLibro
            decimal precioLibro = libros[0].precioLibro; // Suponiendo que solo hay un libro coincidente
            txtPrecioLibro.Text = precioLibro.ToString();
        }
        else
        {
            // Limpia el precio en el cuadro de texto txtPrecioLibro si el libro y la editorial no coinciden
            txtPrecioLibro.Text = "";
        }
       }*/

    }
}
