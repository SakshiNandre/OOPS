using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class PowerIndex
    {
       
        public void Power(int b,int exponential)
        {
            double result = 1.0;
            while(exponential!=0)
            {
                result = result * b;
                --exponential;
            }
            Console.WriteLine("Ans is "+result);
        }
        static void Main(string[] args)
        {
            PowerIndex p = new PowerIndex();
            Console.WriteLine("Enter two number");
            int num = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            p.Power(num,e);
        }
    }
}
