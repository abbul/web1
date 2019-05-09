using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador:Comercio
    {
        ETipoProducto tipo;

        public Exportador(string nombreComercio, float precioAlquier, string nombre, string apellido,ETipoProducto tipo)
            :base(nombreComercio,new Comerciante(nombre,apellido),precioAlquier)
        {
            this.tipo = tipo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendLine("El tipo es : " + tipo.ToString());
            return sb.ToString();
        }
        public static bool operator == (Exportador e1, Exportador e2)
        {
            bool retorno = false;
            if(e1 == e2 && e1.tipo == e2.tipo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (Exportador e1, Exportador e2)
        {
            return (!(e1 == e2));
        }
        public static implicit operator double(Exportador m)
        {
            return m._precioAlquiler;
        }



    }
}
