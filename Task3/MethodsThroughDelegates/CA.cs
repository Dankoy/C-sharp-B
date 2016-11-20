using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThroughDelegates
{
    class CA
    {
        // Methods that will be used by delegate
        public void f_Instance()
        {
            Console.WriteLine("Calling the method of class using delegate.");
        }
        public static void f_Static()
        {
            Console.WriteLine("Calling the static method using delegate.");
        }

        //Callback methods 
        public delegate void Method1Callback(string str1);
        public static void Method1(Method1Callback callback)
        {
            Console.WriteLine("Method1 is working!");
            callback("1");
        }
    }
}
