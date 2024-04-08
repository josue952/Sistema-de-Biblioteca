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
    class ClsAutor
    {
        private int codigo;
        private string nombre;
        private int categoria;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }

        public ClsAutor(int codigo, string nombre, int categoria)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Categoria = categoria;
        }
        AutorDao au = new AutorDao();

        public ClsAutor()
        {
        }
        public DataTable getDatos(string tabla = null)
        {
            return au.consultar(tabla);
        }

        public bool insertarDatos(object datos)
        {
            return au.insertar(datos);
        }

        public bool modificarDatos(object datos)
        {
            return au.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return au.eliminar(codigo);
        }

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return au.buscar(campo, valorCampo);
        }

        internal ClsLibro ClsLibro
        {
            get => default;
            set
            {
            }
        }
    }
}
