using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      Algo esto = new Algo(3, "a");
      Algo dos = new Algo(4, "a");
      if(esto == dos)
      {
        Console.WriteLine("si");
      }
      else
      {
        Console.WriteLine("no {0}", (string)esto);
      }
      Console.ReadKey();
    }
  }
}
