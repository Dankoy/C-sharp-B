using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Class2 obj = new Program.Class2();
            Console.WriteLine(obj.F1());
        }
        //Adding nested class
        class Class2
        {
            // Can be seen only by nested class objects
            private int i1 = 123;

            public int F1()
            {
                return this.i1;
            }
        }
    }
}
