using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetUsuarioTableAdapters;
using System.Data;

namespace BLL1
{
  public  class ClassUsuario
    {
        #region Atributos

        private UsuarioTableAdapter usuario;
        private RolTableAdapter rol;

        #endregion



        #region Propiedades 
        private UsuarioTableAdapter USUARIO
        {
            get
            {
                if (usuario == null)
                {
                    usuario = new UsuarioTableAdapter();
                }
                return usuario;
            }
        }

        private RolTableAdapter ROL
        {
            get
            {
                if(rol == null)
                {
                    rol = new RolTableAdapter();
                }
                return rol;
            }
        }
        #endregion

        #region Metodos 
        public DataTable  Usuario(string _usuario, string _contra)
        {
            DataTable resultado = new DataTable();
            try
            {
               resultado= USUARIO.GetDataByUsuario(_usuario, _contra);
            }
            catch (Exception)
            {

                return null;
            }
            return resultado;
                   
            }
        public DataTable BusquedaRol (int _codigo)
        {
            DataTable resultado = new DataTable();
            try
            {
                resultado = ROL.GetDataByBuscarRol(_codigo);
            }
            catch (Exception)
            {

                return null;
            }

            return resultado;
        }

        public DataTable ListarRol()
        {
            DataTable Resultado = new DataTable();
            Resultado = ROL.GetDataRol();
            return Resultado;
        }
        #endregion
    }
}
