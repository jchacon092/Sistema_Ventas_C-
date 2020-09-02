using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
 public   class ClassDetalleFactura
    {
        //atributos
        int _idProducto;
        int _cantidad;
        decimal _precio;
        decimal _total;
        string _Nombre;

        //propiedades
        public int IDPRODUCTO
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public int CANTIDAD
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public decimal PRECIOU
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public decimal TOTAL

        {
            get { return _total; }
            set { _total = value; }
        }
        public string NOMBRE
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


       
    }
}
