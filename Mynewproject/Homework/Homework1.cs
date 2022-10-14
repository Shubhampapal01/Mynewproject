using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Homework1
    {
        static void Main(string[] args)
        {
            int marks1, marks2, marks3, marks4, marks5, total;
            float Percentage;
            Console.WriteLine("enter subject-1 marks:");
            marks1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter subject-2 marks:");
            marks2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter subject-3 marks:");
            marks3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter subject-4 marks:");
            marks4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter subject-5 marks:");
            marks5 = Convert.ToInt32(Console.ReadLine());


            total = marks1 + marks2 + marks3 + marks4 + marks5;
            Percentage = total / 5.0f;
            Console.WriteLine("final result of{0}is:");
            Console.WriteLine("totak marks:" + total);
            Console.WriteLine("Percentage:" + Percentage);

        }
    }
    class operatormath
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5; b = 4; c = 3;
            Console.WriteLine(a++ +b* ++c);
            Console.WriteLine("a="+a+"b="+b+"c="+c);
            Console.WriteLine(b*5/a+b++ +b);
            Console.WriteLine("a="+a+"b="+b+"c="+c);
        }
    }
     //equilateral triangle
    class prg
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Side:\t");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is:\t" + area);
        }
    }
    //Leap year
    class Prg2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
            else Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
        }
    }




}
