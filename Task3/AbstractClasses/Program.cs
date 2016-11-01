using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassAB varb1 = new ClassAB();
            int a = 10;
            int b = 20;

            Console.WriteLine(varb1.SFig(a, b));

            if (varb1 is Interface1)        // Using operator 'is'
            {
                Console.WriteLine("varb1 is a ref on class implemented Interface1");
            }
            Interface1 ivar = (Interface1)varb1;
            if (ivar is Interface1)
            {
                Console.WriteLine("ivar is the ref to Interface1");
            }
            bool var1 = ivar.F1();
            Console.WriteLine("Using method F1 from Interface1: {0}", var1);

            // Making Object be an interface 
            Object ivar1 = varb1 as Interface1;
            if (ivar1 != null)
            {
                Console.WriteLine("ivar1 is refference to interface Interface1");
            }
        }
    }
}
