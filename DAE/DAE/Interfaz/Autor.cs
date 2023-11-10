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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }
        ClsAutor au = new ClsAutor();
        private void cargar()
        {
            dtAutor.DataSource = au.getDatos();
        }
        private void listarCategorias()
        {
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "CodigoCategoria";
            cbCategoria.DataSource = au.getDatos("listaCategorias");
        }
        private void frmAutor_Load(object sender, EventArgs e)
        {
            cargar();
            listarCategorias();
        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cbCategoria.Text = "";
            txtBuscar.Text = "";
            cbOpcion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                au.Nombre = txtNombre.Text;
                au.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);



                au.insertarDatos(au);
                limpiarCampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show("ocurrio un error al insertar:" + err.Message, "error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = dtAutor.SelectedRows[0].Cells[0].Value.ToString();
            this.txtNombre.Text = dtAutor.SelectedRows[0].Cells[1].Value.ToString();
            this.cbCategoria.Text = dtAutor.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {
                    au.Codigo = Convert.ToInt32(txtCodigo.Text);
                    au.Nombre = txtNombre.Text;
                    au.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);


                    au.modificarDatos(au);
                    limpiarCampos();
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
                    au.eliminarDatos(txtCodigo.Text);
                    cargar();
                    limpiarCampos();
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
                    campo = "CodigoAutor";

                }
                else if (cbOpcion.Text == "Nombre")
                {
                    campo = "NombreAutor";
                }
                else
                {
                    campo = "NombreCategoria";
                }
               
                dtAutor.DataSource = au.buscarRegistro(campo, txtBuscar.Text);
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
            limpiarCampos();
        }
    }
}
