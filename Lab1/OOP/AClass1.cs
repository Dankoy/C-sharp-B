using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class AClass1
    {
        /// <summary>
        /// variable i1
        /// </summary>
        public int i1;
        public const int i2 = 111;

        public AClass1()
            : this(222)
        {
            Console.WriteLine("Class1()");
        }
        public AClass1(int i)
        {
            Console.Write("Class1(i) i= " + i);
            Console.WriteLine();
        }
        public int a_Summa(ref int _i1, int _i2)
        {
            _i1++;
            return _i1 + _i2;
        }
    }
}
