using DAE.DAO;
using DAE.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAE.Clases
{
    internal class ClsCompras
    {
        public ClsCompras()
        {
        }

        public ClsCompras(int codigoCompra, string usuario, DateTime fechaCompra, double total)
        {
            this.codigoCompra = codigoCompra;
            this.usuario = usuario;
            this.fechaCompra = fechaCompra;
            this.total = total;
        }

        private int codigoCompra;
        private string usuario;
        private DateTime fechaCompra;
        private double total;

        public int CodigoCompra { get => codigoCompra; set => codigoCompra = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public double Total { get => total; set => total = value; }

        ComprasDao com = new ComprasDao();

        public DataTable getDatos(string tabla = null)
        {
            return com.consultar(tabla);
        }

        public bool insertarDatos(object datos)
        {
            return com.insertar(datos);
        }

        public bool modificarDatos(object datos)
        {
            return com.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return com.eliminar(codigo);
        }

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return com.buscar(campo, valorCampo);
        }

        internal ClsDetalleCompra ClsDetalleCompra
        {
            get => default;
            set
            {
            }
        }

        internal ClsPrestamo ClsPrestamo
        {
            get => default;
            set
            {
            }
        }
    }
}
