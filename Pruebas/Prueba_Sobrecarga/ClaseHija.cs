using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class ClaseHija : ClasePadre
    {
        public string palabra;
        public ClaseHija(int numero) : base(numero) { }
        public static bool operator ==(ClaseHija c, int numero)
        {
            if(c != null)
            {
                return c.numero == numero;
            }
            return false;
        }
        public static bool operator !=(ClaseHija c, int numero)
        {
            return !(c == numero);
        }
    }
}
