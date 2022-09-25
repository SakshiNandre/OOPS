using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class var_dynamic
    {
        const int n1=500;
        static void Main(string[] args)
        {
            var n ="520";
            n = "ewfjuewfew";
            Console.WriteLine(n);
            dynamic j;
            j = 50;
            j = 5000;
            Console.WriteLine(j);
            const double pie= 3.14;
            Console.WriteLine(pie);
            Console.WriteLine(var_dynamic.n1);
        }
    }
    class practicepalindrome
    {
        public void Palindromeno(int n)
        {
            int copy = n;
            int summ = 0;
            int remm;
            while (copy>0)
            {
                remm = copy % 10;
                copy = copy / 10;
                summ = summ * 10+remm;
            }
            if (n == summ)
            {
                Console.WriteLine("is palindrom");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
        static void Main(string[] args)
        {
            practicepalindrome p = new practicepalindrome();
            Console.WriteLine("Enter a number to check palindrome or not");
            int num = int.Parse(Console.ReadLine());
            p.Palindromeno(num);
        }
    }
}
