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

            Class1 obj = new Class1();
            String s = obj.method1(32);
            Console.WriteLine(s);
            int i = obj.method2("1111");
            Console.WriteLine(i);

            // Using ckecked and unckecked context

            long num1 = int.MaxValue + 20L;
            uint num2 = int.MaxValue - 1000;
            ulong num3 = int.MaxValue;

            int intNumber;

            try
            {
                intNumber = checked((int)num1);
                Console.WriteLine("After assigning value {0}, Integer value will equals {1}.", num1.GetType().Name, intNumber);
            }
            catch (OverflowException)
            {
                if (num1 > int.MaxValue)
                {
                    Console.WriteLine("COnversion failed: {0} exceeds {1}.", num1, int.MaxValue);
                }
                else
                {
                    Console.WriteLine("Conversion failed: {0} is less than {1}.", num1, int.MaxValue);
                }
            }

            try
            {
                intNumber = checked((int)num2);
                Console.WriteLine("After assigning a {0} value, the Integer value is {1}.", num2.GetType().Name, intNumber);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed: {0} exceeds {1}.", num2, int.MaxValue);
            }

            try
            {
                intNumber = checked((int)num3);
                Console.WriteLine("After assigning a {0} value, the Integer value is {1}.", num3.GetType().Name, intNumber);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed: {0} exceeds {1}.", num3, int.MaxValue);
            }
        }
    }
}
