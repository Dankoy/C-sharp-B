using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    class Class1
    {
        protected string nameValue;
    
        public string Name
        {
            get
            {
                return nameValue;
            }
            set
            {
                nameValue = value;
            }
        }

        public Class1()
        {
            nameValue = "Property Value";
        }
    }
}
