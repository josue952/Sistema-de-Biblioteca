using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAE.DAO;

namespace DAE.Clases
{
    class ClsEditorial
    {

        private int codigoEditorial;
        private string nombre;
        private string correo;
        private string direccion;
        private string telefono;

        public int CodigoEditorial { get => codigoEditorial; set => codigoEditorial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public ClsEditorial(int codigoEditorial, string nombre, string correo, string direccion, string telefono)
        {
            this.CodigoEditorial = codigoEditorial;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public ClsEditorial()
        {
        }
        EditorialDao ed = new EditorialDao();
        public DataTable getDatos()
        {
            return ed.consultar();
        }


        public bool insertarDatos(object datos)
        {
            return ed.insertar(datos);
        }
        public bool modificarDatos(object datos)
        {
            return ed.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return ed.eliminar(codigo);
        }
        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return ed.buscar(campo, valorCampo);
        }

    }
}
