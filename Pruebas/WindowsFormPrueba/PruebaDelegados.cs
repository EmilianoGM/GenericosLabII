using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPrueba
{
    public class PruebaDelegados
    {
        public delegate void MiDelegado(int a, int b);
        public void ManejadorDos(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo de intancia ManejadorDos");
        }

        public static void Sumar(int a, int b)
        {
            MessageBox.Show("Suma = " + (a + b).ToString());
        }
    }
}
