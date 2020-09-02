using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.DataSetCompraTableAdapters;
using System.Transactions;

namespace BLL1
{
  public  class ClassCompra
    {
        #region Atributos

        private CompraTableAdapter Emcabezado;
        private Detalle_compraTableAdapter Detalle;

        #endregion



        #region Propiedades 
        private CompraTableAdapter EMCAVEZADO
        {
            get
            {
                if (Emcabezado == null)
                {
                    Emcabezado = new CompraTableAdapter();
                }
                return Emcabezado;
            }
        }

        private Detalle_compraTableAdapter DETALLE
        {
            get
            {
                if(Detalle == null)
                {
                    Detalle = new Detalle_compraTableAdapter();
                }
                return Detalle;
            }
        }
        #endregion

        #region metodos

        private int Insertadetalle(ClassCompraDetalle linea, int _pedido)
        {
            int? resp = 0;
            DETALLE.sp_InsertaCompraDetalle(_pedido, linea.IDPRODUCTO,linea.CANTIDAD,linea .SUBTOTAL, ref resp);
            return (int)resp;
        }

        public string InsertaCompra(List<ClassCompraDetalle> lista_detalle, decimal _precio, int _numero, int _idProv)

        {
            TransactionScope tran = new TransactionScope();
            bool error = false;
            int? codigo_pedido = -1;
            string resultado = "";

            using (tran)
            {
                try
                {
                    EMCAVEZADO.sp_AgregaCompraEncab( _precio,_numero,_idProv , ref codigo_pedido);
                    if (codigo_pedido > 0)
                        foreach (ClassCompraDetalle DET in lista_detalle)
                        {
                            Insertadetalle(DET, (int)codigo_pedido);
                            // DETALLE.sp_InsertaDetallePedido(codigo_pedido,DET.PRODUCTO,DET.PRECIO_UNITARIO,DET.CANTIDAD)
                        }
                    resultado = codigo_pedido.ToString();
                    //resultado = " Se ha grabado el pedido correctamente";
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
