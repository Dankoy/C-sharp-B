using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass1 acl1 = new AClass1();
            AClass1 acl2 = new AClass1(454);

            acl1.i1 = 555;
            Console.Write("i1 = ");
            Console.Write(acl1.i1);
            Console.Write("    i2 = ");
            Console.WriteLine(AClass1.i2);

            Console.WriteLine("a-Summa = ");
            Console.WriteLine(acl1.a_Summa(ref acl1.i1, AClass1.i2));

            Console.Write("i1 = ");
            Console.WriteLine(acl1.i1);
        }
    }
}
