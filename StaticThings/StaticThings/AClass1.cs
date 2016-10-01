using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticThings
{
    public class AClass1
    {
        public static string M1()
        {
            System.DateTime dateTime = new System.DateTime(DateTime.Now.Ticks);
            System.Console.WriteLine("Show dateTime using '(0:D)' {0:D}", dateTime);
            System.Console.WriteLine("Show dateTime using '(0:d)' {0:d}", dateTime);
            System.Console.WriteLine("Show dateTime using '(0:f)' {0:f}", dateTime);
            System.Console.WriteLine("Show dateTime using '(0:F)' {0:F}", dateTime);
            System.Console.WriteLine("Show dateTime using '(0:G)' {0:G}", dateTime);
            return dateTime.ToString();
        }
    }
}
