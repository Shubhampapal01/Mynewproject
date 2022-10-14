using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Homework
{
    class Homework2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            for(int i=1;i<=100;i++)
            {
                if (i % 5 == 0 && i % 10 == 0) 
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine();
        }
    }
    // Predict the table
    class task10
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }
    // Predict the code
    //class task11
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 1;
    //        char K = 1;
    //        while (i++ <= 5)
    //        {
    //            K *= i;
    //        }
    //        Console.WriteLine("k=" + K + "i=" + i);
    //    }
    //}

    // Spy number
    class task12
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
    // trimorphic number
    class task13
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
            if (temp == rem)
            {
                Console.WriteLine("trymorphic");
            }
            else
            {
                Console.WriteLine("not trymorphic");
            }
        }
    }
    //      1
    //     222
    //    33333
    //   4444444

    class task14
    {
        static void Main(string[] args)
        {
            int spc, len = 1, count;
            Console.WriteLine("enter the number");
            count = Convert.ToInt32(Console.ReadLine());
            spc = count - 1;
            for (int i = 1; i <= count; i++)
            {
                for (int r= i; r<= spc; r++)
                {
                    Console.Write(i);
                }
                spc--;
                len = len + 2;
                Console.WriteLine();
            }
        }
    }

    // 1!+2!+3!+4!....n   find sum
    class task23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
                sum = sum + fact;
                Console.WriteLine(i+"!+");
            }
            Console.WriteLine("sum"+sum);
        }
    }
    class task15
    {
        static void Main(string[] args)
        {
         for(int i=1;i<=5;i++)
            {
                for(int k=1;k<=i;k++)
                {
                    Console.Write("  ");
                }
                for(int j=5;j>=i;j--)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
        }
    }
    // 2 12 36 80 150 252....upto 10 terms print  the series//not output
    class task19
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=2;i<=n;i++)
            {
                sum = (i * i) + (i * i * i);
                    Console.WriteLine(sum);
            } 
        }
    }





}
