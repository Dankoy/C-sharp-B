using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDerriv1
{
    public class CA
    {
        // Everybody can access this method
        public int F1()
        {
            return 1;
        }
        // Only methods of tis class and its child classes methods can use this method
        protected int F2()
        {
            return 2;
        }
    }
}
