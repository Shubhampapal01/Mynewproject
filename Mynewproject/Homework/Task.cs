using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("you enter character");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("you enter number");
            }
            else
            {
                Console.WriteLine("you enter special character");
            }
        }
    }

    

}

