﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAssemblyReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get name of assembly
            Console.WriteLine("** External Assembly Viewer **");
            string asmName = "";
            bool userIsDone = false;
            Assembly asm = null;
            do {
                Console.WriteLine("\nEnter an assembly to evaluate");
                Console.Write("or enter Q to quit\n");

                //Get the name of assembly
                asmName = Console.ReadLine();

                // Quit?
                if (asmName.ToUpper() == "Q") {
                    userIsDone = true;
                    break;
                }

                //Dynamic loading of assembly
                try{
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch {
                    Console.WriteLine("Sorry, can't find assembly.");
                }
            } 
                while (!userIsDone);
            }
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("\n***** Types in Assembly *****");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine("Type: {0}", t);
                Console.WriteLine("");
            }
            
        }
    }
}
