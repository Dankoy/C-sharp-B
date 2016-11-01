using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MyDelegate();

namespace MethodsThroughDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            CA var1 = new CA();

            //Instance of MyDelegate
            MyDelegate f_d = new MyDelegate(var1.f_Instance);

            // Calling method f_Instance using delegate
            f_d();

            // New instance of delegate
            f_d = new MyDelegate(CA.f_Static);

            //Calling method f_Static using delegate
            f_d();
        }
    }
}
