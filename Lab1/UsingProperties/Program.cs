using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a1 = new Class1();
            Console.WriteLine("Property Name = {0}", a1.Name);
            a1.Name = "New Property Value";
            Console.WriteLine("New Property Name = {0}", a1.Name);

            ThreeProperties tp = new ThreeProperties { str = "bruh", i = 10, flo = 213f };  // Object Init
            Console.WriteLine("String value = {0} \nInt value = {1} \nFloat value = {2}", tp.str, tp.i, tp.flo);
        }
    }
}
