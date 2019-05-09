using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string nombre;
        protected float _precioAlquiler;


        public int CantidadDeEmpleados {
            get
            {
                if(_cantidadDeEmpleados == 0)
                {
                    _cantidadDeEmpleados = _generadorDeEmpleados.Next(10, 580);
                }
                return _cantidadDeEmpleados;
            }
        }
        static Comercio()
        {
            _generadorDeEmpleados = new Random();
        }
        public Comercio (float precioAlquiler,string nombreComercio,string nombre,string apellido):this(nombreComercio,new Comerciante(nombre,apellido),precioAlquiler)
        {
       
           
        }
        public Comercio(string nombreComercio, Comerciante c1, float precioAlquiler)
        {
            this._comerciante = c1;
            this.nombre = nombreComercio;
            this._precioAlquiler = precioAlquiler;
        }
        private string Mostrar(Comercio c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)c._comerciante);
            sb.AppendLine("El nombre del comercio es  :" + c.nombre);
            sb.AppendLine("La cantidad de empleados es  :" + c._cantidadDeEmpleados);
            sb.AppendLine("El precio del alquiler es : " + c._precioAlquiler);
            return sb.ToString();
        }
        public static bool operator == (Comercio c1, Comercio c2)
        {
            bool retorno = false;
            if(c1.nombre == c2.nombre && c1._comerciante == c2._comerciante)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Comercio c1, Comercio c2)
        {
           
            return (!(c1 == c2));
        }
        public static explicit  operator string(Comercio c1)
        {
            return c1.Mostrar(c1);
        }

    }
}
