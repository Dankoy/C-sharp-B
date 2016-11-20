using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    struct struct1 { }
    class CA
    {
        public class CB_Inside_CA
        {

        }

        public void Method1()
        {
            throw new System.NotImplementedException();
        }

        public void Method2(int i1, ref int i2)
        {
            i2 = i1 + i2;
        }

        public int Method3(string s1)
        {
            return s1.Length;
        }
    }
}
