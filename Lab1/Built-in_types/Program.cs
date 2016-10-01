using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags] enum Colors {None = 0, Red = 1, Green = 2, Blue = 3};

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

            // Using method Parse
            String value = "-204";
            try
            {
                int numb = Int32.Parse(value);
                Console.WriteLine("Converted '{0}' to {1}.", value, numb);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convertsion failure '{0}'.", value);
            }

            string valMin = Double.MinValue.ToString();
            try
            {
                Console.WriteLine(Double.Parse(valMin));
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} overflow for Double type", valMin);
            }
            string valMax = Double.MaxValue.ToString();
            try
            {
                Console.WriteLine(Double.Parse(valMax));
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} overflow for Double type", valMax);
            }

            // Using enum parsing
            string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Greed" };
            foreach (string colorString in colorStrings)
            {
                try
                {
                    Colors colorValue = (Colors)Enum.Parse(typeof(Colors), colorString);
                    if (Enum.IsDefined(typeof(Colors), colorValue) | colorValue.ToString().Contains(","))
                    {
                        Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());
                    }
                    else
                    {
                        Console.WriteLine("{0} - value is missing in enum Colors", colorString);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("'{0}' - is not a member of enum Colors.", colorString);
                }
            }
        }
    }
}
