using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Lists
{
    class MyType
    {
        private string myName;
        private string myPhone;
        public MyType(string strName, string strPhone)
        {
            myName = strName;
            myPhone = strPhone;
        }
        public string Name { get { return myName; } }
        public string Phone { get { return myPhone; } }
    }
}
