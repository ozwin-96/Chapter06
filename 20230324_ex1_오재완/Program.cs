﻿using System;

namespace _20230324_ex1_오재완
{
    class MainApp
    {
        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine($"결과 : {Square(arg)}");
        }
    }
}
