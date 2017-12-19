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
            
            // Comparing anonim types. 
            // Use method "Equals" to compare properties.
            // Use "==" to compare references.
            var v1 = new { Color = "Green", Size = 48, Price = 550 };
            var v2 = new { Color = "Green", Size = 48, Price = 550 };

            // Comparing:
            if (v1.Equals(v2))
            {
                Console.WriteLine("Similar anonim objects.");
            }
            else
            {
                Console.WriteLine("Different anonim objects.");
            }

            if (v1 == v2)
            {
                Console.WriteLine("Similar refs.");
            }
            else
            {
                Console.WriteLine("Different refs.");
            }

            if (v1.GetType().Name == v2.GetType().Name)
            {
                Console.WriteLine("Similar anonim type.");
            }
            else
            {
                Console.WriteLine("Different anonim type.");
            }

            // Overloading
            A objA = new A();
            A objB = new A();
            Console.WriteLine("Comparing using \"Equals\": " + objA.Equals(objB));
            Console.WriteLine("Comparing using overloaded \"==\": " + (objA == objB));
        }
    }

    //Перегрузка операторов
    class A
    {
        int x = 0;
        int y = 0;
        int z = 0;

        //Overloading ==
     /*   public static bool operator ==(A a, A b)
        {
            // If both objects are "null" or both of them are the same instance => true
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If only one object equals "null" => false
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // If objects fields are equal => true
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }
        // Necessary if you overload ==
        public static bool operator != (A a, A b)
        {
            return !(a == b);
        }
        */
    }
}
