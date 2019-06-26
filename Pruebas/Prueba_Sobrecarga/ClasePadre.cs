using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class ClasePadre
    {
        public int numero;
        public ClasePadre(int numero)
        {
            this.numero = numero;
        }
        public static bool operator ==(ClasePadre a, ClasePadre b)
        {
            if (Object.Equals(a, null) && Object.Equals(b, null))
            {
                return true;
            }
            else if (!(Object.Equals(a, null)) && !(Object.Equals(b, null)))
            {
                if (a.numero == b.numero)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(ClasePadre a, ClasePadre b)
        {
            return !(a == b);
        }


    }
}
