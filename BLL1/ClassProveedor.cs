using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetProveedorTableAdapters;
using System.Data;

namespace BLL1
{
   public class ClassProveedor
    {
        #region Atributos

        private ProveedorTableAdapter proveedor;

        #endregion



        #region Propiedades 
        private ProveedorTableAdapter PROVEEDOR
        {
            get
            {
                if (proveedor == null)
                {
                    proveedor = new ProveedorTableAdapter();
                }
                return proveedor;
            }
        }
        #endregion

        #region metodos

        public string InsertarProveedor(string _Nombre, string _NombreRes, string _cargo, string _Direcc, string _ciudad, string _tel)
        {
            string resouesta = "";
            try
            {
                PROVEEDOR.sp_AgregaProveedor(_Nombre, _NombreRes, _cargo, _Direcc, _ciudad, _tel,ref resouesta);

            }
            catch (Exception error)
            {
                resouesta = error.Message;
            }
            return resouesta;
        }

        public DataTable ListarProveedor()
        {
            DataTable Resultado = new DataTable();
            Resultado = PROVEEDOR.GetDataProveedor();
            return Resultado;
        }

        
        #endregion
    }
}
