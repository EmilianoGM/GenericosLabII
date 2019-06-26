using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Sobrecarga
    {
        public int MetodoSobrecargado(int dato)
        {
            return dato + 2;
        }

        public int MetodoSobrecargado(string datoDos)
        {
            if(datoDos == "5")
            {
                int resultado = this.MetodoSobrecargado(5);
                return resultado;
            }
            return -1;
        }
    }
}
