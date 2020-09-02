using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
 public   class ClassVariables
    {
        //atributos
        int _idUsuario;
        string _Empleado;
        string _rol;
        int _idEmpleado;
        decimal _Total;

        //propiedades
        public int IDUSUARIO
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string EMPLEADO
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }
        public string ROL
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public int IDEMPLEADO
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public decimal TOTAL
        {
            get { return _Total; }
            set { _Total = value; }
        }
    }
}
