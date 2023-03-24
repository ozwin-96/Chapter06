using System;

namespace p197_ex1
{
    class MainApp
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
