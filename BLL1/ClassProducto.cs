using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetProductoTableAdapters;
using System.Data;

namespace BLL1
{
  public  class ClassProducto
    {
        #region Atributos

        private ProductoTableAdapter producto;

        #endregion



        #region Propiedades 
        private ProductoTableAdapter PRODUCTO
        {
            get
            {
                if (producto == null)
                {
                    producto = new ProductoTableAdapter();
                }
                return producto;
            }
        }
        #endregion

        #region metodos

        public string InsertarProducto(string _Nombre, string _Descri, string _precio, string _cantidad, DateTime _venci, long _barras)
        {
            string resouesta = "";
            try
            {
               PRODUCTO.sp_AgregaProducto(_Nombre, _Descri, Convert.ToInt32( _precio),Convert.ToInt32(_cantidad),_venci,_barras, ref resouesta);

            }
            catch (Exception error)
            {
                resouesta = error.Message;
            }
            return resouesta;
        }

        public DataTable ListarProducto()
        {
            DataTable Resultado = new DataTable();
            Resultado = PRODUCTO.GetDataProducto();
            return Resultado;
        }

        public DataTable BuscaProducto(int _opcion)
        {
            DataTable resultado = new DataTable();
            try
            {

                resultado = PRODUCTO.GetDataByBuscarProductp(_opcion);
            }
            catch
            {
                resultado = null;
            }
            return resultado;
        }
        public int idproducto(long _codigo)
        {
            int? resp = 0;

            PRODUCTO.sp_IDproducto(_codigo, ref resp);

            return (int)resp;
        }


        #endregion
    }
}
