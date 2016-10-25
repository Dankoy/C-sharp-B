using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class ClassAB : AbstractClass1, Interface1
    {

        public override int SFig(int x, int y)
        {
            return x * y;
        }
        public bool F1()
        {
            return true;
        }
    }
}
