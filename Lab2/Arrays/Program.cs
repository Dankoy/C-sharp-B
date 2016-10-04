using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass1 a1 = new AClass1();

            a1.iArray[0] = 100;
            Console.WriteLine(a1.iArray[0]);
            Console.WriteLine(a1.iArray.GetLength(0));
        }
    }
}
