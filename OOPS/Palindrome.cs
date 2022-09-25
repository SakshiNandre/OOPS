using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Palindrome
    {
        public bool Ispalindrome(int num)
        {
            int copy = num;
            int r;
            int rev = 0;
            while (copy > 0)
            {
                r = copy % 10;
                copy = copy / 10;
                rev = rev * 10 + r;
            }
            return rev == num;
          /*  if (rev == num)
            { 
                Console.WriteLine("NUM IS PALINDROME");
            return true;
            }
            else
                Console.WriteLine("not");
            return false;*/
        }
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
          //  p.Ispalindrome(num);
            bool a= p.Ispalindrome(num);
            Console.WriteLine(a);
           if(p.Ispalindrome(num))
                Console.WriteLine("NUM IS PALINDROME");
            else
                Console.WriteLine("not");
        }
    }
}
