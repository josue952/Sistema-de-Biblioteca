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
    }
}
