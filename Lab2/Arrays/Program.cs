using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass1 a1 = new AClass1();

            a1.iArray[0] = 100;
            Console.WriteLine(a1.iArray[0]);
            Console.WriteLine(a1.iArray.GetLength(0));

            int[,] dArr = new int[6, 3];
            int[,] dArr2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("Elements in array dArr = {0}\n First dimension {1}\n Second dimension {2}", dArr.Length, dArr.GetLength(0), dArr.GetLength(1));
            Console.WriteLine("Elements in array dArr2 = {0}\n First dimension {1}\n Second dimension {2}", dArr2.Length, dArr2.GetLength(0), dArr2.GetLength(1));
            Console.WriteLine("Amount of dimensions of array dArr2 = {0}", dArr2.Rank);
            
           
        }
    }
}
