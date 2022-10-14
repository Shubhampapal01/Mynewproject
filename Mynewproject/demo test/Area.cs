using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.demo_test
{
    class Area
    {
        static void Main(String[] args)
        {
            int r;
            double PI;
            r = 4;
            PI = 3.14;
            double circle_area = PI * r * r;
            Console.WriteLine("Area of circle=" + circle_area);
        }
    }
    class Addition
    {
        static void Main(String[] args)
        {
            int num1, num2, result;
            num1 = 9;
            num2 = 8;
            result = num1 + num2;
            Console.WriteLine("Addition=" + result);
        }
    }
    class Substraction
    {
        static void Main(String[] args)
        {
            int num1, num2, result;
            num1 = 75;
            num2 = 38;
            result = num1 - num2;
            Console.WriteLine("Substraction=" + result);
        }
    }
    class Multiplication
    {
        static void Main(String[] args)
        {
            int num1, num2, result;
            num1 = 23;
            num2 = 45;
            result = num1 * num2;
            Console.WriteLine("Multiplication=" + result);
        }

    }
    class Division
    {
        static void Main(String[] args)
        {
            int num = 6;
           int result = num * num * num;
            Console.WriteLine("cube=" + result);


        }

    }
    class Cube
    {
        static void Main(String[]args)
        {
            int num = 8;
            int result = num * num * num;
            Console.WriteLine("cube=" + result);

            
        }
    }
}
