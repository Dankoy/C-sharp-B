using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    [Attr1]
    class Class1
    {
        private int[,] arr;
        public int this[int ind1, int ind2]
        {
            get { return arr[ind1, ind2]; }
            set { arr[ind1, ind2] = value; }
        }
        public Class1()
        {
            arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        }

        [Attr2]
        public void meth1() { }

        [Attr3("inited_param_1", "inited_param_2", Param3 = 48)]
        public void meth2() { }
    }
}
