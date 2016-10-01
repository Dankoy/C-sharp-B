using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 55;
            Console.WriteLine(myInt.GetType().ToString());

            float myFloat = 123;
            Console.WriteLine(myFloat.GetType().ToString());

            float myFloat2 = (float)123.5;
            Console.WriteLine("{0}   {1}   {2}", myInt, myFloat, myFloat2);
        }
    }
}
