using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tryine to load local copy of dll
            Console.WriteLine("--- Late Binding ---\n");
            Assembly a = null;
            try
            {
                //CarLibrary in bin\debug
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
            
            // Asking a type of Car2 from Assembly
            Type car = a.GetType("CarLibrary.Car2");

            // Creating an object Car2 on the go (using Activator class)
            object obj = Activator.CreateInstance(car);

            //Asking info about next method 
            MethodInfo mi = car.GetMethod("Turbo");

            //Calling this method
            mi.Invoke(obj, null); // without parameter

            //Create array of params
            object[] paramArray = new object[2];
            paramArray[0] = "Fred";
            paramArray[1] = 4;
            mi = car.GetMethod("BeQuiet");

            //Calling this method using late binding mechanism
            mi.Invoke(obj, paramArray);

            Console.WriteLine("Main ended");
            Console.ReadLine();
        }
    }
}
