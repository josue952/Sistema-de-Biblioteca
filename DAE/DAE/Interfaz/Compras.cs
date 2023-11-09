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
        }
        ClsCompras obj = new ClsCompras();

        private void cargar(string consulta = null)//carga los datos de la tabla usuarios
        {
            dtTablaCompras.DataSource = obj.getDatos(consulta);
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

        private void listarEditorial()
        {
            cmbEditorial.DisplayMember = "NombreEditorial";
            cmbEditorial.ValueMember = "CodigoEditorial";
            cmbEditorial.DataSource = obj.getDatos("listaEditorial");
        }

        private void limpiarCampos()
        {
            txtCodigoCompras.Text = "";
            cmbLibros.Text = "";
            cmbEditorial.Text = "";
            cmbUsuario.Text = "";
            txtFechaCom.Text = "";
            txtPrecioLibro.Text = "";
            cmbPorCompras.Text = "";
            txtBuscarCompras.Text = "";
            listarUsuarios();
            listarLibros();
            listarEditorial();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            listarLibros();
            listarEditorial();
            cargar("EXEC ActualizarComprasAgrupadasAuto"); 

            // Agrega controladores de eventos para los cuadros combinados cmbLibros y cmbEditorial
            cmbLibros.SelectedIndexChanged += cmbLibros_SelectedIndexChanged;
            cmbEditorial.SelectedIndexChanged += cmbEditorial_SelectedIndexChanged;
        }
        private void btnAgregarCom_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Libros = cmbLibros.Text;
                obj.Editorial = cmbEditorial.Text;
                obj.Usuario = cmbUsuario.Text;
                obj.FechaCompra = txtFechaCom.Text;
                obj.PrecioLibro = Convert.ToDecimal(txtPrecioLibro.Text);
                obj.insertarDatos(obj);
                limpiarCampos();
                cargar("EXCEC ConsultarCompras");
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
                    obj.Libros = cmbLibros.Text;
                    obj.Editorial = cmbEditorial.Text;
                    obj.Usuario = cmbUsuario.Text;
                    obj.FechaCompra = txtFechaCom.Text;
                    obj.PrecioLibro = Convert.ToDecimal(txtPrecioLibro.Text);
                    obj.modificarDatos(obj);
                    limpiarCampos();
                    cargar("EXCEC ConsultarCompras");
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
                    cargar("EXCEC ConsultarCompras");
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
            if (ComprasAgrpClick == true)
            {
                cargar("ComprasAgrupadas");
            }
            else
            {
                cargar("ComprasUnitarias");
            }
        }

        private void dtTablaCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ComprasAgrpClick == true)
            {
                this.txtCodigoCompras.Text = dtTablaCompras.SelectedRows[0].Cells[0].Value.ToString();
                this.cmbUsuario.Text = dtTablaCompras.SelectedRows[0].Cells[1].Value.ToString();
                this.txtFechaCom.Text = dtTablaCompras.SelectedRows[0].Cells[2].Value.ToString();
                this.txtPrecioLibro.Text = dtTablaCompras.SelectedRows[0].Cells[3].Value.ToString();
                cmbLibros.Text = "";
                cmbLibros.Enabled = false;
                cmbEditorial.Text = ""; 
                cmbEditorial.Enabled = false;
            }
            else
            {
                this.txtCodigoCompras.Text = dtTablaCompras.SelectedRows[0].Cells[0].Value.ToString();
                this.cmbLibros.Text = dtTablaCompras.SelectedRows[0].Cells[1].Value.ToString();
                this.cmbEditorial.Text = dtTablaCompras.SelectedRows[0].Cells[2].Value.ToString();
                this.cmbUsuario.Text = dtTablaCompras.SelectedRows[0].Cells[3].Value.ToString();
                this.txtFechaCom.Text = dtTablaCompras.SelectedRows[0].Cells[4].Value.ToString();
                this.txtPrecioLibro.Text = dtTablaCompras.SelectedRows[0].Cells[5].Value.ToString();
                cmbLibros.Enabled = true;
                cmbEditorial.Enabled = true;
            }
        }
        public void btnVerCompUnit_Click(object sender, EventArgs e)
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
        LibroDB libro = new LibroDB(0);
        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el libro y la editorial seleccionados
            string libroSeleccionado = cmbLibros.Text;
            string editorialSeleccionada = cmbEditorial.Text;

            // Crear una instancia de la clase LibroDB y obtener el precio del libro
            LibroDB libroDB = new LibroDB(0); // 0 es un valor ficticio para el precio inicial
            List<LibroDB> libros = libroDB.Get(libroSeleccionado, editorialSeleccionada);

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
        }

        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el libro y la editorial seleccionados
            string libroSeleccionado = cmbLibros.Text;
            string editorialSeleccionada = cmbEditorial.Text;

            // Crear una instancia de la clase LibroDB y obtener el precio del libro
            LibroDB libroDB = new LibroDB(0); // 0 es un valor ficticio para el precio inicial
            List<LibroDB> libros = libroDB.Get(libroSeleccionado, editorialSeleccionada);

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
        }
    }
}
