using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class IMEI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long i = long.Parse(Console.ReadLine());
            long copy = i;
            int c=0;
            while (i > 0)
            {
                c++;
                i = i / 10;
            }
            if(c!=15)
            {
                Console.WriteLine("Invalid Input");
            }
            long sum = 0;
            long rem;
            long sum1;
            while (copy > 0 && c == 15)
            {
                rem = copy % 10;
                sum1 = sum + rem;
                copy = copy / 10;
                //Console.WriteLine(sum1);
            }
        }
    }
}
