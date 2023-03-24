using System;

namespace p202_ex1
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int q, out int r);
            Console.WriteLine($"a:{a}, b:{b}, q:{q}, r:{r}");
        }
    }
}
