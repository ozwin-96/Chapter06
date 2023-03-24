using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p207_ex1
{
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing... ");
            int sum = 0;
            foreach (int i in args)
            {
                Console.Write($"{i}, ");
                sum += i;
            }
            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
