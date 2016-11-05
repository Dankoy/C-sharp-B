using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Arr
    {
        int f1;
        int f2;
        string s1;

        public int F1 { get { return f1; } set { f1 = value; } }
        public int F2 { get { return f2; } set { f2 = value; } }
        public string S1 { get { return s1; } set { s1 = value; } }

        public Arr(int f1, int f2, string s1)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.s1 = s1;
        }
    }
}
