using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        public static void inArray(int[] i) 
        {
            Console.WriteLine("[0] = {0} [1] = {1}", i[0], i[1]);
        }
        static void Main(string[] args)
        {
            int[][,] jaggedArr = new int[3][,] {
                new int[,] {{1,2}, {3,4}},
                new int[,] {{5,6}, {4,6}, {7,8}},
                new int[,] {{0,0}, {0,0}, {0,0}}
            };
            Console.WriteLine("Rank of jagged array: " + jaggedArr.Rank + "\nLength of jagged array: " + jaggedArr.Length);
            Console.WriteLine("First element of jagged array: {0}", jaggedArr[0][1, 0]);

            inArray(new int[] { 1, 4 });

            var a = new[] { 1, 10, 100, 1000 };
            var s = new[] { "string1", null, "string2" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
                
        }
    }
}
