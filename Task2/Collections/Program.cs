using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        public static void printCollection(IEnumerable list1)
        {
            System.Collections.IEnumerator myEnumerator = list1.GetEnumerator();    //Enumerator object created

            while (myEnumerator.MoveNext())
            {
                Console.Write("\t{0}", myEnumerator.Current);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            ArrayList aList1 = new ArrayList();
            aList1.Add("Collection");
            aList1.Add("of type");
            aList1.Add("ArrayList");

            float f1 = 22.34F;
            aList1.Add(f1);

            Console.WriteLine("Collection: ");
            Console.WriteLine("\tCount: {0}", aList1.Count);    //Amount of elements in collection
            Console.WriteLine("\tCapacity: {0}", aList1.Capacity);  //Capacity of collection

            printCollection(aList1);
        }
    }
}
