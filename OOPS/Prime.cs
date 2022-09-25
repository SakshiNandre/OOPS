using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Prime
    {
        public bool IsPrime(int n)
        {
            
            for (int i =2;i<=n/2;i++)
            {
                if (n % i == 0)
                {
                    return false;
                    
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Prime p = new Prime();
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            bool a = p.IsPrime(n);
            Console.WriteLine(a);
        }
    }
    class exp
    {
        public bool PowerExp(int num,int expo)
        {
            if(num==0 || num==1|| num<0)
            {
                return false;
            }
            double result = 1;
            while(num!=0)
            {
                result = result * num;
                --expo;
            }
            return true;
           // Console.WriteLine("ans is "+result);
        }
        static void Main(string[] args)
        {
            exp e = new exp();
            Console.WriteLine("Enter base as a num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter expotential as a expo");
            int expo = int.Parse(Console.ReadLine());
            e.PowerExp(num, expo); 
        }
    }
}
