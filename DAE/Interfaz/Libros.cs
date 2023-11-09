﻿using System;
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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }
        ClsLibro li = new ClsLibro();
        private void cargar()
        {
            dtLibros.DataSource = li.getDatos();
        }
        private void listarCategorias()
        {
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "CodigoCategoria";
            cbCategoria.DataSource = li.getDatos("listaCategorias");
        }
        private void listarAutores()
        {
            cbAutor.DisplayMember = "NombreAutor";
            cbAutor.ValueMember = "CodigoAutor";
            cbAutor.DataSource = li.getDatos("listaAutores");
        }
        private void listarEditorial()
        {
            cbEditorial.DisplayMember = "NombreEditorial";
            cbEditorial.ValueMember = "CodigoEditorial";
            cbEditorial.DataSource = li.getDatos("listaEditorial");
        }


        private void frmLibros_Load(object sender, EventArgs e)
        {
            cargar();
            listarCategorias();
            listarAutores();
            listarEditorial();
            limpiarCampos();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txttitulo.Text = "";
            txtStock.Text = "";
            cbCategoria.Text = "";
            cbAutor.Text = "";
            cbEditorial.Text = "";
            cbEstado.Text = "";
            txtPrecio.Text = "";
            txtBuscar.Text = "";
            cbOpcion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                li.CodigoLibro = txtCodigo.Text;
                li.NombreLibro = txttitulo.Text;
                li.Autor = int.Parse(cbAutor.Text);
                li.Editorial = int.Parse(cbEditorial.Text);
                li.Categoria = int.Parse(cbCategoria.Text);
                li.Stock = int.Parse(txtStock.Text);
                li.Precio = double.Parse(txtPrecio.Text);
                li.EstadoLibro = cbEstado.Text;

                li.insertarDatos(li);
                limpiarCampos();
                cargar();
            }
            catch (Exception err)
            {
                MessageBox.Show("ocurrio un error al insertar:" + err.Message, "error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = dtLibros.SelectedRows[0].Cells[0].Value.ToString();
            this.txttitulo.Text = dtLibros.SelectedRows[0].Cells[1].Value.ToString();
            this.txtStock.Text = dtLibros.SelectedRows[0].Cells[2].Value.ToString();
            this.cbAutor.Text = dtLibros.SelectedRows[0].Cells[3].Value.ToString();
            this.cbCategoria.Text = dtLibros.SelectedRows[0].Cells[4].Value.ToString();
            this.cbEditorial.Text = dtLibros.SelectedRows[0].Cells[5].Value.ToString();
            this.txtPrecio.Text = dtLibros.SelectedRows[0].Cells[6].Value.ToString();
            this.cbEstado.Text = dtLibros.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {

                    li.CodigoLibro = txtCodigo.Text;
                    li.NombreLibro = txttitulo.Text;
                    li.Autor = Convert.ToInt32(cbAutor.SelectedValue); ;
                    li.Editorial = Convert.ToInt32(cbEditorial.SelectedValue);
                    li.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    li.Stock = int.Parse(txtStock.Text);
                    li.Precio = double.Parse(txtPrecio.Text);
                    li.EstadoLibro = cbEstado.Text;

                    li.modificarDatos(li);
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
                    li.eliminarDatos(txtCodigo.Text);
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
                    campo = "ISBN";

                }
                else if (cbOpcion.Text == "Nombre")
                {
                    campo = "NombreLibro";
                }
                else if (cbOpcion.Text == "Categoria")
                {
                    campo = "Categoria";
                }
                else
                {
                    campo = "Autor";
                }
                dtLibros.DataSource = li.buscarRegistro(campo, txtBuscar.Text);
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