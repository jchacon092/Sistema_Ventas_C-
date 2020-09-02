using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetEmpleadoTableAdapters;
using System.Data;

namespace BLL1
{
  public  class ClassEmpleado
    {
        #region Atributos

        private EmpleadoTableAdapter empleado;

        #endregion



        #region Propiedades 
        private EmpleadoTableAdapter EMPLEADO
        {
            get
            {
                if (empleado == null)
                {
                    empleado = new EmpleadoTableAdapter();
                }
                return empleado;
            }
        }
        #endregion

        #region metodos

        public string InsertarEmpleado(string _Nombre, string _Apellido, string _Direcc, string _Ciudad, string _Tel, string _Correo, string _Usuario, string _Contrasenia, int _rol)
        {
            string resouesta = "";
            try
            {
                EMPLEADO.sp_AgregaEmpleadoUsuario(_Nombre, _Apellido, _Direcc, _Ciudad, _Tel, _Correo, _Usuario, _Contrasenia,_rol, ref resouesta);

            }
            catch (Exception error)
            {
                resouesta = error.Message;
            }
            return resouesta;
        }

        public DataTable BusqueEmpleado(int _codigo)
        {
            DataTable resultado = new DataTable();
            try
            {
                resultado = EMPLEADO.GetDataByBuscarEmpleado(_codigo);
            }
            catch (Exception)
            {

                return null;
            }

            return resultado;
        }

        #endregion
    }
}
