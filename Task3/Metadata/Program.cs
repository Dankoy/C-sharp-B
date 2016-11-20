using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatIsType("System.Char");
            WhatIsType("Metadata.struct1");
            WhatIsType("Metadata.Program");
            WhatIsType("Metadata.CA");
            WhatIsType("Metadata.CA+CB_Inside_CA");

            // Recieving information about methods using reflection
            CA ca = new CA();
            Type tCA = Type.GetType("Metadata.CA");
            Console.WriteLine("Type of CA class: " + tCA);

            Console.WriteLine();

            MethodInfo[] miCA = tCA.GetMethods();
            Console.WriteLine("Class CA. Amount of methods: {0}", miCA.Length);
            Console.WriteLine();

            foreach (MethodInfo met in miCA)
            {
                Console.WriteLine(met.Name);
                Console.WriteLine("Return type = {0}", met.ReturnType.FullName);
                foreach (ParameterInfo par in met.GetParameters())
                {
                    Console.WriteLine("Parameter name - {0}, parameter type {1}", par.Name, par.ParameterType);
                }
                Console.WriteLine();
            }

        }

        // Method the call for metadata
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
