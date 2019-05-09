using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        public double PrecioDeExportadores {
            get {
                return this.ObtenerPrecio(EComercio.Exportador);
            }
             
        }
        public double PrecioDeImportador
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Importador);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Ambos);
            }
        }


        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }
        private Shopping(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public static string Mostrar(Shopping s1)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Comercio c1 in s1._comercios)
            {
                if(c1 is Importador)
                {
                    sb.AppendLine(((Importador)c1).Mostrar());
                }
                else if(c1 is Exportador)
                {
                    sb.AppendLine(((Exportador)c1).Mostrar());
                }
            }
            return sb.ToString();
        }
       public static implicit operator Shopping(int capacidad)
        {
            Shopping s1 = new Shopping(capacidad);
            return s1;
        }
        public static bool operator == (Shopping s1, Comercio c2)
        {
            bool retorno = false;
            foreach(Comercio c1 in s1._comercios)
            {
                if(c1 == c2)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Shopping s1, Comercio c2)
        {
            return (!(s1 == c2));
        }
        public static Shopping operator + (Shopping s1, Comercio c1)
        {
            if(s1._comercios.Count < s1._capacidad && s1 != c1)
            {
                s1._comercios.Add(c1);
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el Shopping!!");
            }
            return s1;
        }
        private double ObtenerPrecio(EComercio c1)
        {
            double acumulador = 0;
            foreach (Comercio a in this._comercios)
            {
                switch (c1)
                {
                    case EComercio.Importador:
                            if(a is Importador)
                        {

                            acumulador = (Importador)a;
                        }
                        break;
                    case EComercio.Exportador:
                        if (a is Exportador)
                        {

                            acumulador = (Exportador)a;
                        }
                        break;
                    case EComercio.Ambos:
                        if (a is Exportador)
                        {

                            acumulador = (Exportador)a;
                        }
                        else if (a is Importador)
                            {

                                acumulador = (Importador)a;
                            }

                        break;
                    default:
                        break;
                }
            }
            return acumulador;
        }


    }
}
