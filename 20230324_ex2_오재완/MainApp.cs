﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230324_ex2_오재완
{
    class MainApp
    {
        public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, ref mean);

            Console.WriteLine($"평균 : {mean}");
        }
    }
}
