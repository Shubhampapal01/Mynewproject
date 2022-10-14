using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Ternaryeven
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter any numbar");
            n = int.Parse(Console.ReadLine());
            string str = (n % 2 == 0) ? ("Nmber is even") : ("Nmber is odd");
                {
                Console.WriteLine(n+"is"+str);
                Console.WriteLine();
            }
        }
    }
}
