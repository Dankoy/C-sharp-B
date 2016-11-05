using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SelfMade
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1[2, 1]);
            Type type = class1.GetType();
            Attr1 attr1 = (Attr1)Attribute.GetCustomAttribute(type, typeof(Attr1));
            //Attr2 attr2 = (Attr2)Attribute.GetCustomAttribute(type, typeof(Attr2));

            Console.WriteLine(class1.GetType().GetMethods().First().GetType());
            Attr3 attr3 = null;
            foreach (MethodInfo mi in class1.GetType().GetMethods())
            {
                if (mi.Name.Equals("meth2"))
                {
                    attr3 = (Attr3)mi.GetCustomAttribute(typeof(Attr3));
                }
            }
            Console.WriteLine("Attr param1: {0},  param2: {1}, param3: {2}", attr3.Param1, attr3.Param2, attr3.Param3);

            Hashtable map = new Hashtable();
            map.Add("key1", 12);
            map.Add("key3", 122323);
            map.Add("key2", 12321321);
            show(map);
        }

        public static void show(Hashtable map)
        {
            foreach (object key in map.Keys)
            {
                Console.WriteLine("key: {0},   value: {1}", key, map[key]);
            }
        }
    }
}
