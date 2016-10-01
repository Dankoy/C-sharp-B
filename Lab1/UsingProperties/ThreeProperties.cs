using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    class ThreeProperties
    {
        private string strValue;
        private float floValue;
        private int iValue;

        public string str
        {
            get
            {
                return strValue;
            }
            set
            {
                strValue = value;
            }
        }

        public float flo
        {
            get
            {
                return floValue;
            }
            set
            {
                floValue = value;
            }
        }
        public int i
        {
            get
            {
                return iValue;
            }
            set
            {
                iValue = value;
            }
        }
    }
}
