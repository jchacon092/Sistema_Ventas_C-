using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL1
{
    public class ClassCompraDetalle
    {
        //atributos
        int _idProducto;
        int _cantidad;
        
        decimal _subTotal;

        //propiedades
        public int IDPRODUCTO
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public int  CANTIDAD
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

      
        public decimal SUBTOTAL
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
    }
}
