using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class AClass1
    {
        public AClass1():this(222)
        {
            Console.WriteLine("Class1()");
        }
        public AClass1(int i)
        {
            Console.Write("Class1(i) i= " + i);
            Console.WriteLine();
        }
    }
}
