using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAE.Clases;

namespace DAE.Interfaz
{
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }
        ClsEditorial ed = new ClsEditorial();
        private void cargar()
        {
            dtEditorial.DataSource = ed.getDatos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void limpiarcampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtBuscar.Text = "";
            cbOpcion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                ed.Nombre = txtNombre.Text;
                ed.Direccion = txtDireccion.Text;
                ed.Telefono = txtTelefono.Text;
                ed.Correo = txtCorreo.Text;

                ed.insertarDatos(ed);
                limpiarcampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show("ocurrio un error al insertar:" + err.Message, "error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtEditorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.txtCodigo.Text = dtEditorial.SelectedRows[0].Cells[0].Value.ToString();
            this.txtNombre.Text = dtEditorial.SelectedRows[0].Cells[1].Value.ToString();
            this.txtCorreo.Text = dtEditorial.SelectedRows[0].Cells[2].Value.ToString();
            this.txtDireccion.Text = dtEditorial.SelectedRows[0].Cells[3].Value.ToString();
            this.txtTelefono.Text = dtEditorial.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {
                    ed.CodigoEditorial = int.Parse(txtCodigo.Text);
                    ed.Nombre = txtNombre.Text;
                    ed.Direccion = txtDireccion.Text;
                    ed.Telefono = txtTelefono.Text;
                    ed.Correo = txtCorreo.Text;

                    ed.modificarDatos(ed);
                    limpiarcampos();
                    cargar();
                }
                catch (Exception err)
                {
                    MessageBox.Show("ocurrio un error al modificar:" + err.Message, "error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                string mensaje = "seguro que desea eliminar el contenido?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(mensaje, "ELIMINANDO", buttons, icon);
                if (result == DialogResult.Yes)
                {
                    ed.eliminarDatos(txtCodigo.Text);
                    cargar();
                    limpiarcampos();
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "" && cbOpcion.Text != "")
            {
                string campo;
                if (cbOpcion.Text == "Codigo")
                {//validar opciones de busqueda
                    campo = "CodigoEditorial";

                }
                else if (cbOpcion.Text == "Nombre")
                {
                    campo = "NombreEditorial";
                }
                else
                {
                    campo = "CorreoEditorial";
                }
                dtEditorial.DataSource = ed.buscarRegistro(campo, txtBuscar.Text);
            }
            else
            {
                string mensaje = "ingresar parametros de busqueda";
                MessageBox.Show(mensaje, "informacion!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
            limpiarcampos();
        }
    }
}
