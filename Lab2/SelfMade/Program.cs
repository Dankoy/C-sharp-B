using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMade
{
    class Program
    {
        private static void InitializeMatrix(double[,] matrix, int XDim, int YDim)
        {
            Random rnd = new Random();

            for (int i = 0; i < XDim; ++i)
                for (int j = 0; j < YDim; ++j)
                {
                    matrix[i, j] = E ? 0.00 : rnd.Next(1, 100);
                }
        }
        static void Main(string[] args)
        {
            double[,] A1 = new double[10,10];
            InitializeMatrix(A1, 10, 10);
        }
    }
}
