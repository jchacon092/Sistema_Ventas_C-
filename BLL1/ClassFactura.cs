using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetFacturaTableAdapters;
using System.Transactions;
namespace BLL1
{
  public  class ClassFactura
    {
        #region Atributos

        private Encabezado_facturaTableAdapter Emcabezado;
        private Detalle_facturaTableAdapter Detalle;

        #endregion



        #region Propiedades 
        private Encabezado_facturaTableAdapter EMCAVEZADO
        {
            get
            {
                if (Emcabezado == null)
                {
                    Emcabezado = new Encabezado_facturaTableAdapter();
                }
                return Emcabezado;
            }
        }

        private Detalle_facturaTableAdapter DETALLE
        {
            get
            {
                if (Detalle == null)
                {
                    Detalle = new Detalle_facturaTableAdapter();
                }
                return Detalle;
            }
        }
        #endregion

        #region metodos

        private int Insertadetalle(ClassDetalleFactura linea, int _pedido)
        {
            int? resp = 0;
            DETALLE.sp_InsertaDetalleFactura(linea.CANTIDAD,0, linea.IDPRODUCTO, _pedido, ref resp);
            return (int)resp;
        }

        public string InsertaCompra(List<ClassDetalleFactura> lista_detalle, string _nombre, string _direccion, string _nit, string _descu, string _total, string _numeracion, string _empleado, string _serie, int _num)

        {
            TransactionScope tran = new TransactionScope();
            bool error = false;
            int? codigo_pedido = -1;
            string resultado = "";

            using (tran)
            {
                try
                {
                    EMCAVEZADO.sp_AgregaFacturaEncabezado(_nombre,_direccion,_nit,Convert.ToInt32( _numeracion),Convert.ToDecimal ( _descu),Convert.ToDecimal( _total),Convert.ToInt32 ( _serie),Convert.ToInt32( _empleado),_num, ref codigo_pedido);
                    if (codigo_pedido > 0)
                        foreach (ClassDetalleFactura DET in lista_detalle)
                        {
                            Insertadetalle(DET, (int)codigo_pedido);
                            // DETALLE.sp_InsertaDetallePedido(codigo_pedido,DET.PRODUCTO,DET.PRECIO_UNITARIO,DET.CANTIDAD)
                        }
                   // resultado = codigo_pedido.ToString();
                   resultado = " Se ha grabado el pedido correctamente";
                }
                catch (Exception err)
                {
                    resultado = "Error:" + err.Message;
                    error = true;
                }
                if (!error)
                    tran.Complete(); //aqui confirma la transaccion COMMIT TRAN
            }//Fin transaccion
            return resultado;

        }

        #endregion
    }
}
