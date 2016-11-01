using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimTypes
{
    class Program
    {
        static void reflectType(object obj)
        {
            Console.WriteLine("Object is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
        }
        static void Main(string[] args)
        {
            //anonim object
            var anon = new { num = 123, strin = "qwerty", dem = 54 };
            reflectType(anon);
            
        }
    }
}
