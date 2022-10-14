using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.demo_test
{
    class com
    {
        static void Main(string[] args)
        {
            int r;
            double PI;
            r= int.Parse(Console.ReadLine());
            PI = 3.14;
            double circle_area = PI * r * r;
            Console.WriteLine("Area of Circle="+circle_area);
        }
    }
}
