using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Meter
    {
        static void Main(string[] args)
        {
            double cm, meter, km;
            cm = 1000;
            meter = cm / 100.0;
            km = cm / 100000.0;
            Console.WriteLine("enter length in centimeter="+cm);
            Console.WriteLine("length in meter="+meter);
            Console.WriteLine("length in kilometer="+km);

        }
    }
}
