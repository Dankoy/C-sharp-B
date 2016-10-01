using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_types
{
    class Class1
    {
        public string method1(int i)
        {
            return "Parameter i = " + System.Convert.ToString(i);
        }
        public int method2(string s)
        {
            return  System.Convert.ToInt32(s);
        }
    }
}
