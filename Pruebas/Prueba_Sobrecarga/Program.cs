using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sobrecarga prueba = new Sobrecarga();
            int numero = prueba.MetodoSobrecargado("5");
            Console.WriteLine(numero);
            */

            /*-----------------------------------*/

            /*
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                int numero = random.Next(0, 3);
                PruebaEnum.EPrueba prueba = (PruebaEnum.EPrueba)Enum.ToObject(typeof(PruebaEnum.EPrueba), numero);
                Console.WriteLine(prueba);
            }
            */

            /* ---PRUEBA EQUALS Y SOBRECARGA == PARA NULL---
            ClaseHija uno = new ClaseHija(5);
            ClaseHija dos = new ClaseHija(5);
            ClaseHija tres = null;
            Console.WriteLine(tres == null);
            Console.WriteLine(uno == 4);
            */

            /*---PRUEBA INTERFAZ---*/
            /*
            ClaseConInterfaces claseConInterfaces = new ClaseConInterfaces();
            ((InterfazUno)claseConInterfaces).Algo(4); // No produce nada
            */

            /*---PRUEBA SERIALIZADOR---*/
            /*
            Serializador serializador = new Serializador();
            ClaseSerializar claseSerializar = new ClaseSerializar("hola", 2, 5);
            //No rompe aunque no se especifique el tipo entre <>
            serializador.SerializarXML(claseSerializar);
            //Si no recibe argumento no puede inferir el tipo y hay que especficarlo
            ClaseSerializar nueva = serializador.DeserializarXML<ClaseSerializar>();

            Console.WriteLine(Object.Equals(nueva, null));
            */
            //NO BORRAR
            Console.WriteLine("\n----TERMINADO---");
            Console.ReadKey();
        }
    }
}
