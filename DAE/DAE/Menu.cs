using DAE.Clases;
using DAE.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAE
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //variable para saber cual formulario esta abierto
        private Form FormularioActivo = null;
        private void AbrirFormulario(Form FormularioHijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(FormularioHijo);
            panelFormularioHijo.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //agregando datos de sesion para mostrar datos en pantalla
            lblUser.Text = "Usuario: " + UserLoginCache.userName;
            lblRol.Text = "Nivel de Acceso: \n" + UserLoginCache.rolUser;
            if (UserLoginCache.rolUser == "Administrador")
            {

            }
            else if (UserLoginCache.rolUser == "Bibliotecario")
            {
            }
            else if (UserLoginCache.rolUser == "Estudiante")
            {
            }
            else if (UserLoginCache.rolUser == "Proveedor")
            {
            }
            else if (UserLoginCache.rolUser == "Normal")
            {
            }
            else //cuando el usuario no esta registrado
            {
            }
            panelSubMenuAdmin.Visible = false;//esconde el panel submenu de administrar

        }
        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            panelSubMenuAdmin.Visible = true;//muestrame el panel submenu de administrar
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios()); 
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAutor());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }
        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            panelSubMenuAdmin.Visible = false;//esconde el panel submenu de administrar

        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "Seguro que desea cerrar sesion?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(mensaje, "Cerrando Sesion", botones, icon);
            if (result == DialogResult.Yes)
            {
                // Cerrar el formulario menu y mostrar el formulario login
                this.Close();
            }

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLibros());
        }

        private void brnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCompras());
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEditorial());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCategoria());
        }

    }
}
