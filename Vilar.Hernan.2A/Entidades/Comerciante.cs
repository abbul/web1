using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        private string apellido;
        private string nombre;

        public Comerciante(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static bool operator == (Comerciante c1, Comerciante c2)
        {
            bool retorno = false;
            if(c1.nombre == c2.nombre && c1.apellido == c2.apellido)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (Comerciante c1, Comerciante c2)
        {
            return (!(c1 == c2));
        }
        public static implicit operator string(Comerciante c1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El nombre del comerciante es{0}\nEl Apellido del comerciante es {1}\n", c1.nombre, c1.apellido);
            return sb.ToString();
        }
    }
}
