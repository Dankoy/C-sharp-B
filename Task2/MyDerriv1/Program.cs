using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDerriv1
{
    class Program
    {
        static void Main(string[] args)
        {
            CA vara1 = new CA();
            CB varb1 = new CB();

            Console.WriteLine(vara1.F1());
            Console.WriteLine(varb1.F1());
            // Console.WriteLine(varb1.F2()); // Can't access protected method
            Console.WriteLine(varb1.F3()); //Actual access of protected method of base class

            // Accessing CA.F3();
            Console.WriteLine(vara1.F3());

            // Using virtual methods
            CA varc1 = new CA();
            CB vard1 = new CB();

            Console.WriteLine(varc1.VirtualF4());
            Console.WriteLine(vard1.VirtualF4());

            Console.WriteLine(varc1.F3());
            Console.WriteLine(vard1.F3());
        }
    }
}
