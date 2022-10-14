using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Per
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


            total  = marks1 + marks2 + marks3 + marks4 + marks5;
            Percentage = total / 5.0f;
            Console.WriteLine("final result of{0}is:");
            Console.WriteLine("totak marks:"+total);
            Console.WriteLine("Percentage:"+Percentage);







        }
    }
}
