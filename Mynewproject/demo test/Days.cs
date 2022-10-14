using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.demo_test
{
    class Days
    { 
        static void Main(String[]args)
        {
            Console.WriteLine("enter days");
            int days = int.Parse(Console.ReadLine());
            int year = (days / 365);
            int week = (days % 365) / 7;
            days = (days % 365) % 7;
            Console.WriteLine("year=" + year);
            Console.WriteLine("week="+ week);
            Console.WriteLine("days="+days);
        }
    }
}
