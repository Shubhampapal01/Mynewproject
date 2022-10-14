using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Desk3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend Age");
            int fage = Convert.ToInt32(Console.ReadLine());
            if(age>21)
            {
                Console.WriteLine("Hii");
            }
            else if(age<21)
            {
                Console.WriteLine("Good Morning");

            }
            else 
            {
                Console.WriteLine("How Are You");
            }
        }
    }
}
