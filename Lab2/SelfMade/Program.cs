using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    matrix[i, j] = rnd.Next(1, 100);
                }
        }
        // Method returns matrix[i,j] element
        private static int getElement1(int i, int j, int[,] matrix)
        {
            return matrix[i, j];
        }
        static void Main(string[] args)
        {
            int[,] A1 = new int[10,10];
            InitializeMatrix(A1, 10, 10);
            Console.WriteLine(getElement1(4, 6, A1));
        }
    }
}
