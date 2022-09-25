using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class OverLoad
    {
        public void num_calc(int num, char ch)
        {
            if (ch == 's')
            {
                int sq = num * num;
                Console.WriteLine("squre is " + sq);
            }
            else if (ch != 's')
            {
                int cube = num * num * num;
                Console.WriteLine("cube is " + cube );
            }
        }
        public void num_calc(int a,int b,char ch)
        {
            if (ch=='p')
            {
                int c = a * b;
                Console.WriteLine("product is "+c);
            }
            else if (ch!='p')
            {
                int h = a + b;
                Console.WriteLine("addition is "+h);
            }
        }
        static void Main(string[] args)
        {
            OverLoad o = new OverLoad();
            o.num_calc(5, 's');
            o.num_calc(5, 5, 'p');
        }
    }
}
