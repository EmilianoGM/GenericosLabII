using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaDelegados pruebaDelegados = new PruebaDelegados();
            EventHandler eventHandler = new EventHandler(pruebaDelegados.ManejadorDos);
            PruebaDelegados.MiDelegado delegado = new PruebaDelegados.MiDelegado(PruebaDelegados.Sumar);
            MessageBox.Show(delegado.Method.ToString());
            MessageBox.Show(eventHandler.Target.ToString());
            string c = "";
            delegado.Invoke(5, 3);
            foreach (Delegate d in eventHandler.GetInvocationList())
            {
                c += d.Target.ToString() + " - ";
            }
            MessageBox.Show(c);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog1.Title = "Seleccione un archivo a abrir";
            this.openFileDialog1.DefaultExt = ".txt";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.Filter = "*(.txt)| *.TXT";
            */
        }
    }
}
