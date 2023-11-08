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
            listarUsuarios();
            listarLibros();
            listarEditorial();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            listarLibros();
            listarEditorial();

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
                    obj.Libros = cmbLibros.Text;
                    obj.Editorial = cmbEditorial.Text;
                    obj.Usuario = cmbUsuario.Text;
                    obj.FechaCompra = txtFechaCom.Text;
                    obj.PrecioLibro = Convert.ToDecimal(txtPrecioLibro.Text);
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
                else { campo = "FechaCompra"; }//Si no es ninguna opcion anterior buscara por fechaCompra
                dtTablaCompras.DataSource = obj.buscarRegistro(campo, txtBuscarCompras.Text);
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
            ComprasAgrpClick = false;
            cargar("ComprasUnitarias");
        }
        private bool ComprasAgrpClick = false;
        public void btnVerCompAgrp_Click(object sender, EventArgs e)
        {
            ComprasAgrpClick = true;
            cargar("ComprasAgrupadas");
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
