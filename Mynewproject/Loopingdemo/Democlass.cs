using System;
using System.Collections.Generic;
using System.Text;

namespace Mynewproject.Loopingdemo
{
    class Democlass
    {
        static void Main(string[] args)
        {
            int  sum;
            sum = 0;
            Console.WriteLine("enter number");
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);


                    sum = sum + i;
                }
                Console.WriteLine(sum);
                




            }
            
        }
    }     
}
