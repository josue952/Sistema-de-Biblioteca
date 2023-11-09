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
    internal class ClsLibro
    {
        private string codigoLibro;
        private string nombreLibro;
        private int autor;
        private int editorial;
        private int categoria;
        private int stock;
        private double precio;
        private string estadoLibro;

        public ClsLibro()
        {
        }

        public ClsLibro(string codigoLibro, string nombreLibro, int autor, int editorial, int categoria, int stock, double precio, string estadoLibro)
        {
            this.CodigoLibro = codigoLibro;
            this.NombreLibro = nombreLibro;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Categoria = categoria;
            this.Stock = stock;
            this.Precio = precio;
            this.EstadoLibro = estadoLibro;
        }

        public string CodigoLibro { get => codigoLibro; set => codigoLibro = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public int Autor { get => autor; set => autor = value; }
        public int Editorial { get => editorial; set => editorial = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public string EstadoLibro { get => estadoLibro; set => estadoLibro = value; }

        LibroDao li = new LibroDao();

        public DataTable getDatos(string tabla=null)
        {
            return li.consultar(tabla);
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
    }   
}

