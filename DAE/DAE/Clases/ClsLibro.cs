using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DAE.DAO;

namespace DAE.Clases
{
    class ClsLibro
    {
        private string codigoLibro;
        private string nombre;
        private int codAutor;
        private int codEditorial;
        private int codCategoria;
        private int stock;
        private double precio;
        private string estado;

        public ClsLibro()
        {
        }

        public ClsLibro(string codigoLibro, string nombre, int codAutor, int codEditorial, int codCategoria, int stock, double precio, string estado)
        {
            this.CodigoLibro = codigoLibro;
            this.Nombre = nombre;
            this.CodAutor = codAutor;
            this.CodEditorial = codEditorial;
            this.CodCategoria = codCategoria;
            this.Stock = stock;
            this.Precio = precio;
            this.Estado = estado;
        }

        public string CodigoLibro { get => codigoLibro; set => codigoLibro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CodAutor { get => codAutor; set => codAutor = value; }
        public int CodEditorial { get => codEditorial; set => codEditorial = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Estado { get => estado; set => estado = value; }

        LibroDao li = new LibroDao();


        public DataTable getDatosCat(string tabla = null)
        {
            return li.consultarCat(tabla);

        }
        public DataTable getDatosAu(string tabla = null)
        {
            return li.consultarAu(tabla);
        }
        public DataTable getDatosEd(string tabla = null)
        {
            return li.consultarEd(tabla);
        }

        public bool insertarDatos(object datos)
        {
            return li.insertar(datos);
        }

        public bool modificarDatos(object datos)
        {
            return li.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return li.eliminar(codigo);
        }

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return li.buscar(campo, valorCampo);
        }

        internal ClsCompras ClsCompras
        {
            get => default;
            set
            {
            }
        }
    }
}
