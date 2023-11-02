using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//
using DAE.DAO;

namespace DAE.Clases
{
    internal class ClsUsuario
    {
        private int userId;
        private string usuario;
        private string contra;
        private string rol;
        private string departamento;

        public ClsUsuario()
        {
        }

        public ClsUsuario(int userId, string usuario, string contra, string rol, string departamento)
        {
            this.userId = userId;
            this.usuario = usuario;
            this.contra = contra;
            this.rol = rol;
            this.departamento = departamento;   
        }

        public int UserId { get => userId; set => userId = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        UsuarioDao us = new UsuarioDao();

        public DataTable getDatos()
        {
            return us.consultar();
        }

        public bool insertarDatos(object datos)
        {
            return us.insertar(datos);
        } 

        public bool modificarDatos(object datos)
        {
            return us.modificar(datos);
        }

        public bool eliminarDatos(string codigo)
        {
            return us.eliminar(codigo);
        }

        public DataTable buscarRegistro(string campo, string valorCampo)
        {
            return us.buscar(campo, valorCampo);
        }

        public bool getLogin()
        {
            return us.Login(this.usuario, this.contra);
        }
    }
}
