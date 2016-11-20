using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SelfMade
{
    class Program
    {
        // Initialize matrix
        private static void InitializeMatrix(int[,] matrix, int XDim, int YDim)
        {
            Random rnd = new Random();

            for (int i = 0; i < XDim; ++i)
                for (int j = 0; j < YDim; ++j)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
        }
        // Method returns matrix[i,j] element
        private static int getElement1(int i, int j, int[,] matrix)
        {
            return matrix[i, j];
        }
        // Method using references
        private static void getElement2(ref int elemen, int i, int j, int[,] matrix) {
            elemen = matrix[i, j];
        }
        // Method returns i,j using references and LINQ
        private static void getElement3(ref int i, ref int j, int[][] matrix, int find_number)
        {
            
        }
        static void Main(string[] args)
        {
            int[,] A1 = new int[10,10];
            InitializeMatrix(A1, 10, 10);
            Console.WriteLine(getElement1(4, 6, A1));

            int elem = 0;
            getElement2(ref elem, 4, 6, A1);
            Console.WriteLine(elem);

            int[,] A2 = new int[20, 20];
            InitializeMatrix(A2, 20, 20);

            // Adding reference elements
            int refI = 0;
            int refJ = 0;
            // The number we search for:
            int find_num = 4;

        }
    }
}
