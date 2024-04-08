using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAE.DAO;

namespace DAE.Clases
{
    class ClsCategoria
    {
        private int codigo;
        private string nombre;
        private string descripcion;

        public ClsCategoria()
        {
        }

        public ClsCategoria(int codigo, string nombre, string descripcion)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        CategoriaDao cat = new CategoriaDao();
        public DataTable getDatos()
        {
            return cat.consultar();
        }


        public bool insertarDatos(object datos)
        {
            return cat.insertar(datos);
        }
        public bool modificarDatos(object datos)
        {
            return cat.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return cat.eliminar(codigo);
        }
        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return cat.buscar(campo, valorCampo);


        }

        internal ClsAutor ClsAutor
        {
            get => default;
            set
            {
            }
        }
    }

}
