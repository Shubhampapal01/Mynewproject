using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Oopsdemo
{
    class Car
    {
        public int mid;
        public string name;
        public string colour;
        public int price;
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.mid = 10;
            car1.name = "Harier";
            car1.colour = "Black";
            car1.price = 1600000;
            Console.WriteLine(car1.mid+" "+car1.name+" "+car1.colour+" "+car1.price);

            Car car2 = new Car();
            car2.mid = 12;
            car2.name = "Scorpio";
            car2.colour = "White";
            car2.price = 1300000;
            Console.WriteLine(car2.mid+" "+car2.name+" "+car2.colour+" "+car2.price);

            Car car3 = new Car();
            car3.mid = 15;
            car3.name = "Baleno";
            car3.colour = "Red";
            car3.price = 1400000;
            Console.WriteLine(car3.mid+" "+car3.name+" "+car3.colour+" "+car3.price);
        }
    }
    class Box
    {
        public int height;
        public int breadth;
        public int length;
        public int Area;
        static void Main(string[] args)
        {
            Box b = new Box();
            b.height = 10;
            b.breadth = 6;
            b.length = 15;
            b.Area = b.length * b.breadth;
            Console.WriteLine(b.Area+"Area");



            


        }
    }
    // Percentage/student
    class Student
    {
        public int sid;
        public string name;
        public int marks;
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.sid = 1;
            stud1.name = "shiv";
            stud1.marks = 60;

        }
    }
}
