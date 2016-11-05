using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    [AttributeUsage(AttributeTargets.Method)]
    class Attr3 : Attribute
    {
        private string param1;
        private string param2;
        private int param3;
        public string Param1 { get { return param1; } set { param1 = value; } }
        public string Param2 { get { return param2; } set { param2 = value; } }
        public int Param3 { get { return param3; } set { param3 = value; } }
        public Attr3(string param1, string param2)
        {
            this.param1 = param1;
            this.param2 = param2;
            this.param3 = 22;
        }
    }
}
