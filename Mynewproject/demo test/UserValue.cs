using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.demo_test
{
    class UserValue
    {
        static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter the value");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine(num*5);
        }
    }
}
