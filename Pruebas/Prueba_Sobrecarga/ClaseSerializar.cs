using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class ClaseSerializar
    {
        public string palabra;
        public int numero;
        private int error; //No rompe en ejecucion con atributos privados, 
                           //solo no lo serializa/deserializa
        /*
        public int Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
            }
        }
        */
        public ClaseSerializar()
        {

        }

        public ClaseSerializar(string a, int b, int c)
        {
            palabra = a;
            numero = b;
            error = c;
        }
    }
}
