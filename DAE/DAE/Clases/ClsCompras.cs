using DAE.DAO;
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

        public ClsCompras(int codigoCompra, string libros, string editorial, string usuario, DateTime fechaCompra, decimal precioLibro, decimal totalCompra)
        {
            this.codigoCompra = codigoCompra;
            this.libros = libros;
            this.editorial = editorial;
            this.usuario = usuario;
            this.fechaCompra = fechaCompra;
            this.precioLibro = precioLibro;
            this.totalCompra = totalCompra;
        }

        private int codigoCompra;
        private string libros;
        private string editorial;
        private string usuario;
        private DateTime fechaCompra;
        private decimal precioLibro;
        private decimal totalCompra;


        public int CodigoCompra { get => codigoCompra; set => codigoCompra = value; }
        public string Libros { get => libros; set => libros = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public decimal PrecioLibro { get => precioLibro; set => precioLibro = value; }
        public decimal TotalCompra { get => totalCompra; set => totalCompra = value; }

        ComprasDao com = new ComprasDao();
        public DataTable getDatos(string tabla = null)
        {
            return com.consultar();
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

    }
}
