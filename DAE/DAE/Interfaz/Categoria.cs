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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            if (UserLoginCache.rolUser == "Bibliotecario")
            {
                btnEliminar.Enabled = false;
            }
        }
        ClsCategoria cat = new ClsCategoria();

        private void cargar()
        {
            dtCategoria.DataSource = cat.getDatos();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();

        }
        private void limpiarcampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtBuscar.Text = "";
            cbOpcion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                cat.Nombre = txtNombre.Text;
                cat.Descripcion = txtDescripcion.Text;
               

                cat.insertarDatos(cat);
                limpiarcampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show("ocurrio un error al insertar:" + err.Message, "error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtCodigo.Text = dtCategoria.SelectedRows[0].Cells[0].Value.ToString();
            this.txtNombre.Text = dtCategoria.SelectedRows[0].Cells[1].Value.ToString();
            this.txtDescripcion.Text = dtCategoria.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {
                    cat.Codigo = int.Parse(txtCodigo.Text);
                    cat.Nombre = txtNombre.Text;
                    cat.Descripcion = txtDescripcion.Text;
                 

                    cat.modificarDatos(cat);
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
                    cat.eliminarDatos(txtCodigo.Text);
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
                    campo = "CodigoCategoria";

                }
                else
                {
                    campo = "NombreCategoria";
                }
               
                dtCategoria.DataSource = cat.buscarRegistro(campo, txtBuscar.Text);
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
