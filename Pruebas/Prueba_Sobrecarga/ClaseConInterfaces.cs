using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class ClaseConInterfaces : InterfazUno, InterfazDos
    {
        /* IMPLEMENTACION EXPLICITA: no llevan modificador y no pueden usarse fuera de la clase */
        string InterfazUno.Algo(int a)
        {
            return a.ToString() + " UNO";
        }

        string InterfazDos.Algo(int b)
        {
            return b.ToString() + " DOS";
        }
    }
}
