using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public virtual int numeroUno()
        {
            return 2;
        }
    }

    public class Class2 : Class1
    {
        public override int numeroUno()
        {
            return 3;
        }
    }
}
