using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Disarumno
    {
        public void Disarum(int num)
        {
            int copy = num;
            int r = 0;
            int c = 0;
            int sum = 0;
            while (num > 0)
            {
                c++;
                num = num / 10;
            }
            num = copy;
            while (num > 0)
            {
                r = num % 10;
                sum = (int)(sum + Math.Pow(r, c));
                c--;
                num = num / 10;
            }
            Console.WriteLine("sum is " + sum);
            if (sum==copy)
                Console.WriteLine("Disarum number");
            else
                Console.WriteLine("Not a Disarum number");
        }
    
        static void Main(string[] args)
        {
            Disarumno d = new Disarumno();
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            d.Disarum(num);
        }
    }
}
