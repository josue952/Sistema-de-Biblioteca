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
    class ClsMulta
    {
        private int codigoMulta;
        private int codigoPrestamo;
        private DateTime fechaMulta;
        private double costoMulta;
        private string estadoMulta;

        public int CodigoMulta { get => codigoMulta; set => codigoMulta = value; }
        public int CodigoPrestamo { get => codigoPrestamo; set => codigoPrestamo = value; }
        public DateTime FechaMulta { get => fechaMulta; set => fechaMulta = value; }
        public double CostoMulta { get => costoMulta; set => costoMulta = value; }
        public string EstadoMulta { get => estadoMulta; set => estadoMulta = value; }

        public ClsMulta(int codigoMulta, int codigoPrestamo, DateTime fechaMulta, double costoMulta, string estadoMulta)
        {
            this.CodigoMulta = codigoMulta;
            this.CodigoPrestamo = codigoPrestamo;
            this.FechaMulta = fechaMulta;
            this.CostoMulta = costoMulta;
            this.EstadoMulta = estadoMulta;
        }

        public ClsMulta()
        {
        }
        MultaDao mul = new MultaDao();
        public DataTable getDatos(string tabla = null)
        {
            return mul.consultar(tabla);
        }



        public bool insertarDatos(object datos)
        {
            return mul.insertar(datos);
        }

        public bool modificarDatos(object datos)
        {
            return mul.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return mul.eliminar(codigo);
        }
      

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return mul.buscar(campo, valorCampo);
        }
    }
}
