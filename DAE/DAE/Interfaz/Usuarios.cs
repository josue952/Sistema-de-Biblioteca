using DAE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAE.Interfaz
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        ClsUsuario obj = new ClsUsuario();
        private void cargar()//carga los datos de la tabla usuarios
        {
            dtTablaUsuarios.DataSource = obj.getDatos();
        }

        private void limpiarCampos()
        {
            txtCodigoUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            cmbCargoUsuario.Text = "";
            cmbDepartamentoUsuario.Text = "";
        }

        private void btnAgregarUs_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Usuario = txtNombreUsuario.Text;
                obj.Contra = txtContraseñaUsuario.Text;
                obj.Rol = cmbCargoUsuario.Text;
                obj.Departamento = cmbDepartamentoUsuario.Text;
                obj.insertarDatos(obj);
                limpiarCampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al insertar: {err.Message}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarUs_Click(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.Text != "")
            {
                try
                {
                    obj.UserId = int.Parse(txtCodigoUsuario.Text);
                    obj.Usuario = txtNombreUsuario.Text;
                    obj.Contra = txtContraseñaUsuario.Text;
                    obj.Rol = cmbCargoUsuario.Text;
                    obj.Departamento = cmbDepartamentoUsuario.Text;
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

        private void btnEliminarUs_Click(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.Text != "")
            {
                string mensaje = "Seguro que desea eliminar?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(mensaje, "Eliminando", buttons, icon);
                if (result == DialogResult.Yes)
                {
                    obj.eliminarDatos(txtCodigoUsuario.Text);
                    cargar();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBuscarUs_Click(object sender, EventArgs e)
        {
            if (txtBuscarUsuarios.Text != "" && cmbPorUsuarios.Text != "")
            {
                string campo;
                if (cmbPorUsuarios.Text == "Código")
                {
                    campo = "CodigoUser";
                }
                else if (cmbPorUsuarios.Text == "Departamento")
                {
                    campo = "UserDepartamento";
                }
                else { campo = "UserRol"; }//Si no es ninguna opcion anterior buscara por rol
                dtTablaUsuarios.DataSource = obj.buscarRegistro(campo, txtBuscarUsuarios.Text);
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios o incompletos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTableUs_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)//carga los datos de la tabla usuarios
        {
            cargar();
            dtTablaUsuarios.Columns[2].Visible = false;//oculta el campo contraseña

        }

        private void dtTablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                this.txtCodigoUsuario.Text = dtTablaUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                this.txtNombreUsuario.Text = dtTablaUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                this.txtContraseñaUsuario.Text = dtTablaUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                this.cmbCargoUsuario.Text = dtTablaUsuarios.SelectedRows[0].Cells[3].Value.ToString();
                this.cmbDepartamentoUsuario.Text = dtTablaUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            
        }
    }
}
