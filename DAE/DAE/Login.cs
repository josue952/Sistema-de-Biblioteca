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
using DAE.Interfaz;

namespace DAE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "") 
            {
                if (txtPassword.Text != "")
                {
                    ClsUsuario us = new ClsUsuario();
                    //set a los atributos de la clase
                    us.Usuario = txtUser.Text;
                    us.Contra = txtPassword.Text;
                    var validarLogin = us.getLogin();
                    if (validarLogin == true)
                    {
                        FrmMenu menu = new FrmMenu();//instancia al formulario
                        menu.Show();//mostrar formulario menu
                        //sobrecargar el metodo FormClosed del formulario menu para cuando cerremos la sesion
                        menu.FormClosed += LogOut;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                else
                {
                    MessageBox.Show("La Contraseña es obligatoria!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Usuario es obligatorio!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            this.Show();
            txtUser.Focus();    
        }

        private void btnUserNotRegistred_Click(object sender, EventArgs e)
        {
            // Crear un nuevo usuario temporal
            ClsUsuario us = new ClsUsuario();
            UserLoginCache.userName = "Sin Usuario";
            UserLoginCache.rolUser = "Temporal";

            // Mostrar el formulario del menú
            FrmMenu menu = new FrmMenu();
            menu.Show();

            // Ocultar el formulario de login
            this.Hide();
            menu.FormClosed += LogOut;
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.btnEditar.Enabled = false;
            frm.btnEliminar.Enabled = false;
            frm.TablaUsers.Visible = false;
            frm.BuscarDatos.Visible = false;
            frm.cmbCargoUsuario.Enabled = false;
            frm.cmbCargoUsuario.Text = "Normal";
            frm.btnRegresarLogin.Visible = true;
            frm.btnEliminar.Visible = false;
            frm.btnEditar.Visible = false;
            frm.txtContraseñaUsuario.PasswordChar = '\0';
            frm.CrudUsers.Location = new Point(200, 150);
            frm.CrudUsers.Size = new Size(180, 90);
            frm.btnAgregar.Size = new Size(158, 62);
            frm.Size = new Size(850, 300);
            frm.Show();
        }
    }
}
