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
            System.Console.WriteLine("{0:d}", dateTime);
            return dateTime.ToString();
        }
    }
}
