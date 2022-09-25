using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Binaryno
    {
        public bool Binary(int num)
        {

            if (num == 0 || num == 1
                || num < 0)
            {
                return false;
            }

          
            while (num != 0)
            {

                
                if (num % 10 > 1)
                {
                    return false;
                }
                num = num / 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Binaryno b = new Binaryno();
            Console.WriteLine("Enter a number ");
            int a = int.Parse(Console.ReadLine());
            bool H = b.Binary(a);
            Console.WriteLine(H);
        }
    }
}
