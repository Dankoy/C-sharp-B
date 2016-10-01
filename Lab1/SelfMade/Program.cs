using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateObj obj1 = new DateObj();
            DateObj obj2 = new DateObj(System.DateTime.Now.ToShortDateString());
            DateObj obj3 = new DateObj(System.DateTime.Now.ToShortDateString(), System.DateTime.Now.ToShortTimeString());
        }
    }
}
