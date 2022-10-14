using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Desk1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("\n number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("\n number is negative");
            }
            else if(num==0)
            {
                Console.WriteLine("\n number is zero");
            }

        }
    }
}
