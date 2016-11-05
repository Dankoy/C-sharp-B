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
        }
    }
}
