using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Method
    {
        public bool Evenodd(int num)
        {
            if (num % 2 == 0)
            {
            return true;
            }
            else
            {
                return false;
            }
              //  return false;

        }
        static void Main(string[] args)
        {
            Method m = new Method();
            Console.WriteLine( "Enter a number");
            int n = int.Parse(Console.ReadLine()); 
           bool a= m.Evenodd(n);
            Console.WriteLine(a);
            
        }
    }
}
