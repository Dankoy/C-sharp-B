using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            // Will be used as data sources
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            string[] words = { "apple", "orange", "cherry" };

            var numQuery = from num in numbers where (num % 2) == 0 select num;
            var varWords = from w in words select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
            foreach (var ul in varWords)
            {
                Console.WriteLine("UpperCase letter: {0}, LowerCase letter: {1}", ul.Upper, ul.Lower);
            }
        }
    }
}
