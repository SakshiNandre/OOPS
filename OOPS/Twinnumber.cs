using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Twinnumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool Isprime = true || false;
            for (int i = 1; i <= num / 2; i++)
            {

                if (num%i == 0)
                {
                  //  { }
                        Isprime = false;
                   
                   
                }
                else
                {
                   // { }
                        Isprime = true;
                }

            }
             int n = int.Parse(Console.ReadLine());
            bool Isprime1 = true || false;
            for (int j = 1; j <= n / 2; j++)
            {
                if (n % j == 0)
                {
                   // { }
                    Isprime1 = false;
                }
                else
                {
                   // { }
                    Isprime1 = true;
                }
            }
                if ((Isprime == true  && Isprime1 == true) &&((num-n==2)||(n-num==2)))
                    { 
                            Console.WriteLine("twin prime");
                    }
                
                else if((Isprime==Isprime1 )&&((num-n==2)||(n-num==2)))
                    Console.WriteLine("not");
            



        }
    }
}

