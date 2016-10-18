using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// My custom attribute

namespace Indexation
{
    class MyAttribute : System.Attribute
    {
        private string name;
        private int kod;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Kod
        {
            get
            {
                return kod;
            }
            set
            {
                kod = value;
            }
        }
    }
}
