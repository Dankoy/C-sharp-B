using System;
using System.Collections.Generic;
using System.Linq;
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
