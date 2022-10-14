using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Loopingdemo
{
    class prg
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    // #
    // ##
    // ###
    // ####
    // #####
    // ######
    class A
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

    }
    //   1
    //   1 2
    //   1 2 3
    //   1 2 3 4
    class B
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();


            }
        }

    }
    // 1
    // 2 2
    // 3 3 3
    // 4 4 4 4
    class C
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

    }
    // 1 2 3 4
    // 1 2 3
    // 1 2
    // 1
    class D
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i--)
            {
                for (int j = 1; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //1234
    //1234
    //1234
    //1234
    class E
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    //      *
    //     **
    //    ***
    //   ****
    class F
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    //     *
    //    * *
    //   * * *
    //  * * * *
    class G
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)

                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

        }

    }
    // 1
    // 10
    // 101
    // 1010
    // 10101
    class H
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)

                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }

        }
    }
    // A
    // B B
    // C C C
    // D D D D
    class I
    {
        static void Main(string[] args)
        {


            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    // A
    // A B
    // A B C
    // A B C D
    class J
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class K
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char k = 'A'; k < i; k--)
                {
                    Console.Write("  ");
                }
                for (char j = 'D'; j >= 'A'; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
    }
    // 12345
    // 1234
    // 123
    // 12
    // 1
    class L
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //1
    //23
    //456
    class M
    {
        static void Main(string[] args)
        {
            int i, j, num = 1;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
    // table

    class N
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
    //Automorphic
    class Auto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;
            int square = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num % 10;
            }
            Console.WriteLine(count);

            temp = num;
            int power = 1;
            int Base = 10;
            square = num * num;
            for (int i = 1; i <= count; i++)
            {
                power = power * Base;
            }
            int last = square % power;
            if (num == last)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }




        }
    }
    // Harshad number
    class Har
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            if (sum % count == 0)
            {
                Console.WriteLine("is a Harshad number");
            }
            else
            {
                Console.WriteLine("not Harshad");
            }
        }
    }
    // kapareker number or not
    class kapere
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter thr number");
            int n = int.Parse(Console.ReadLine());
            int count = 0, t = 0;
            int sum = 0;
            int real = n;
            t = n * n;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            n = real;
            int power = (int)(Math.Pow(10, count));
            int end = t % power;
            int start = t / power;
            //Console.WriteLine(end+"end");
            //Console.WriteLine("start"+start);
            sum = (end + start);
            if (sum == real)
            {
                Console.WriteLine("kapreker");
            }
            else
            {
                Console.WriteLine("not kapreker");
            }
        }
    }
    //0,7,27,63.......
    class series
    {
        static void Main(string[] args)
        {
            int i;
            i = 1;
            do
            {
                Console.WriteLine(i * i * i - 1);
                i++;
            }
            while (i <= 10);

        }
    }
    //100 99 98 97.........91
    class series1
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 91; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }

    //display number 1 to 10
    class series2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
    //2 6 12 20 30.....110
    class series3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i + i);
            }
            Console.WriteLine();
        }
    }
    // Duck number or not
    class Duc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int real = n;
            bool isduck = true;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    isduck = false;
                    break;
                }
                n = n / 10;
            }
            if (real > 0 && isduck == false)
            {
                Console.WriteLine("duck number");
            }
            else
            {
                Console.WriteLine("not duck");
            }
        }
    }
    // * pattern in plus shape
    class plus
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    //1 4 9 16 25....100
    class series4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
    //3 6 9 12......30
    class series5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 3);
            }
        }
    }
    //1 to n  table
    class table
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
            Console.WriteLine();


        }
    }
    // 1 11 111 1111.....
    class rav
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = (sum * 10) + 1;
                int t = sum + 10;
                Console.Write(" ");
                    Console.Write(sum);
            }
            Console.Write(" ");
           
        }
    }
    //fibbonaci series
    class fibbonaci
    {
        static void Main(string[] args)
        {
            int a = 0,b = 1;
            for(int i=1;i<=20;i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }
        }
    }
    //pattern
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
                if(i%2==0)
                {
                    char ch = 'A';
                    for(int j=1; j<=i;j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                 else
                {
                    for(int k=1;k<=i;k++)
                    {
                        Console.Write(k);
                    }
                }
                  Console.WriteLine();
        }
    }



}