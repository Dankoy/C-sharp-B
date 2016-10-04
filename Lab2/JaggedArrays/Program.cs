using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArr = new int[3][,] {
                new int[,] {{1,2}, {3,4}},
                new int[,] {{5,6}, {4,6}, {7,8}},
                new int[,] {{0,0}, {0,0}, {0,0}}
            };
            Console.WriteLine("Rank of jagged array: " + jaggedArr.Rank + "\nLength of jagged array: " + jaggedArr.Length);
            Console.WriteLine("First element of jagged array: {0}", jaggedArr[0][1, 0]);
        }
    }
}
