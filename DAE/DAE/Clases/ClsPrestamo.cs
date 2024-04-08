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
    class ClsPrestamo
    {
        private int codigoPrestamo;
        private DateTime fechaPrestamo;
        private double total;
        private string usuario;

        public ClsPrestamo()
        {
        }

        public ClsPrestamo(int codigoPrestamo, DateTime fechaCompra, double total, string usuario)
        {
            this.CodigoPrestamo = codigoPrestamo;
            this.FechaPrestamo = fechaPrestamo;
            this.Total = total;
            this.Usuario = usuario;
        }

        public int CodigoPrestamo { get => codigoPrestamo; set => codigoPrestamo = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public double Total { get => total; set => total = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        PrestamoDao pre = new PrestamoDao();
        public DataTable getDatos(string tabla = null)
        {
            return pre.consultar(tabla);
        }


        public bool insertarDatos(object datos)
        {
            return pre.insertar(datos);
        }

        public bool modificarDatos(object datos)
        {
            return pre.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return pre.eliminar(codigo);
        }

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return pre.buscar(campo, valorCampo);
        }

        internal ClsMulta ClsMulta
        {
            get => default;
            set
            {
            }
        }

        internal ClsDetallePrestamo ClsDetallePrestamo
        {
            get => default;
            set
            {
            }
        }
    }
}
