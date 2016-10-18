using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexation
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass1 obj = new AClass1();
            obj[0] = 100;
            obj[1] = 200;
            obj[2] = 300;
            Console.WriteLine("1 - {0}, 2 - {1}, 3 - {2}", obj[0], obj[1], obj[2]);
            method();
        }
        [Obsolete("Warning message, showing by compiler.")]
        public static void method()
        {

        }
    }
}
