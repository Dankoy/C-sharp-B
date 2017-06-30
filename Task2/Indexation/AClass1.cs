using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexation
{
    [My("AClass1", Kod=25)] // Attribute goes to class AClass1
    class AClass1
    {
        private int[] imyArray = new int[20]; //Collection

        public int this[int i]  //Indexator for collection above
        {
            get
            {
                return imyArray[i];
            }
            set
            {
                imyArray[i] = value;
            }
        }
    }
}
