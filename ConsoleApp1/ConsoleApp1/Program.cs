using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 primero = new Class1();
            Class2 segundo = new Class2();
            Console.WriteLine(primero.numeroUno());
            Console.WriteLine(segundo.numeroUno());
            Console.ReadKey();
        }
    }
}
