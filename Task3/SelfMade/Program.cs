using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tCA = Type.GetType("SelfMade.CA");
            MethodInfo[] miCA = tCA.GetMethods();
            Console.WriteLine("Methods count in CA: " + miCA.Length);
            foreach (MethodInfo info in miCA)
            {
                Console.WriteLine(info.Name);
                //Console.WriteLine(info.ReturnType.FullName);
                foreach (ParameterInfo param in info.GetParameters())
                {
                    Console.WriteLine("\tName: " + param.Name);
                    Console.WriteLine("\tType: " + param.ParameterType);
                }
            }
        }
        public static void WhatIsType(string s)
        {
            try
            {
                Type tp = Type.GetType(s);
                Console.WriteLine("Type name: {0}", tp.FullName);
                Console.WriteLine("\tIs it class? {0}", tp.IsClass);
                Console.WriteLine("\tIs it abstract class? {0}", tp.IsAbstract);
                Console.WriteLine("\tIs it inner and public? {0}", tp.IsNestedPublic);
                Console.WriteLine("\tIs it final? {0}", tp.IsSealed);
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Type error");
            }
        }
    }
}
