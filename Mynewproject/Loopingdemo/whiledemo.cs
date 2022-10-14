using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Loopingdemo

{
    class whiledemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class whilereverse
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    class while1
    {
        static void Main(string[] args)
        {
            int i = 35;
            while (i <= 75)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    class while2
    {
        static void Main(string[] args)
        {
            int i = 60;
            while (i >= 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    class forloop
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class forloop1
    {
        static void Main(string[] args)
        {
            int cube;
            for (int i = 1; i <= 10; i++)
            {
                cube = i * i * i;
                Console.WriteLine(cube);
            }
        }
    }
    //Palindrom
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int r = 0;
            int rno = 0;
            int t = n;
            while (n != 0)
            {
                r = n % 10;
                rno = rno * 10 + r;
                n = n / 10;
            }
            if (rno == 0)
            {
                Console.WriteLine("Palindrom");

            }
            else
            {
                Console.WriteLine(" not Palindrom");
            }
        }
    }


    class Day1
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day in Number");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not valid day value");

                    break;






            }
        }
    }
    //calculate Area,rectangle,square,triangle
    class cal

    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter character ");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 'a':
                    {
                        Console.WriteLine("Enter Radius for Circle");
                        float r = float.Parse(Console.ReadLine());

                        float area = (float)3.14 * r * r;
                        Console.WriteLine("Area of Circle:" + area);
                        break;
                    }

                case 'b':
                    {
                        Console.WriteLine("Enter base and height:");
                        float b = float.Parse(Console.ReadLine());
                        float h = float.Parse(Console.ReadLine());
                        float a = (float)0.5 * b * h;
                        Console.WriteLine("Area of triangle:" + a);
                        break;
                    }

                case 'c':
                    {
                        Console.WriteLine("Enter Side of Square:");
                        int s = int.Parse(Console.ReadLine());
                        int a = s * s;
                        Console.WriteLine("Area of Square is:" + a);
                        break;
                    }

                case 'd':
                    {
                        Console.WriteLine("Enetr length and Breadth of Reactangle:");
                        int l = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int a = l * b;
                        Console.WriteLine("Area of Rectangle:" + a);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid Data");
                        break;
                    }

            }
        }
    }
    ///spy number
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 3 digit number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int multiplication = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = (r + r + r);
                multiplication = (r * r * r);
                num = num / 10;
            }
            Console.WriteLine(sum + " " + num);
            Console.WriteLine(multiplication + " " + num);
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("number is spy");

            }
            else
            { 
            Console.WriteLine("not spy");
            }

        }
    }
    //Trymorphic
    class Try
    {
        static void Main(string[] args)
        {
            int c;
            int rem;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            c = num * num * num;
            rem = c % 10;
            if(temp==rem)
            {
                Console.WriteLine("trymorphic");
            }
            else
            {
                Console.WriteLine("not trymorphic");
            }
        }
    }
}
 
