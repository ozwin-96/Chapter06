using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p211_ex1
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}
