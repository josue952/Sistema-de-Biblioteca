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
    public partial class frmListMultas : Form
    {
        public frmListMultas()
        {
            InitializeComponent();
        }
        ClsMulta mul = new ClsMulta();
        private void cargar()
        {
            dtMulta.DataSource = mul.getDatos();
        }



        private void frmListMultas_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
