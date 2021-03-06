﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        // Access elements of collections
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

            // Access elements of collection
            printCollection(aList1);

            // Initializators of collections
            List<int> dig1 = new List<int> { 0, 1, 2, 3, 4, 5 };
            foreach (int c in dig1)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            // Printing colection using LINQ
            var numQuery = from num in dig1 select num.ToString();
            foreach (string num in numQuery)
            {
                Console.Write(num + " ");
            }

            Arr arr1 = new Arr(1111, 425, "MSU");
            Arr arr2 = new Arr(34, 45, "hello");
            Arr arr3 = new Arr(168, 12, "program");
            List<Arr> arrayClassaArr = new List<Arr> { arr1, arr2, arr3 };

            var arrQuery =
               from qwert in arrayClassaArr
               select qwert;

            foreach (var element in arrQuery)
            { 
                Console.WriteLine("f1 = {0},\tf2 = {1},\ts1 = {2}", element.F1, element.F2, element.S1); 
            }
        }
    }
}
