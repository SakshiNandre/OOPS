using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Frequency_of_each_digit
    {
        static void Main(string[] args)
        {
            long mb = 99532;
            long r5 = mb % 10;
            mb = mb / 10;
            long r4 = mb % 10;
            mb = mb / 10;
            long r3 = mb % 10;
            mb = mb / 10;
            long r2 = mb % 10;
            mb = mb / 10;
            long r1 = mb % 10; 

           int count=0;
            if(r1==r1)
            { count++; }
            if (r1==r2)
            { count++; }
            if (r1 == r3)
            { count++; }
            if (r1==r4)
            { count++;}
            if (r1==r5)
            { count++; }

            int count2 = 0;
            if(r2==r2)
            { count2++; }
            if (r2==r1)
            { count2++; }
            if(r2==r3)
            { count2++;}
            if (r2==r4)
            { count2++; }
            if (r2 == r5)
            { count2++; }

            int count3 = 0;
            if(r3==r3)
            { count3++; }
            if(r3==r1)
            { count3++; }
            if(r3==r2)
            { count3++; }
            if(r3==r4)
            { count3++; }
            if(r3==r5)
            {count3++; }

            int count4 = 0;
            if(r4==r4)
            { count4++; }
            if(r4==r1)
            { count4++; }
            if(r4==r2)
            { count4++; }
            if(r4==r3)
            { count4++; }
            if(r4==r5)
            { count4++; }

            int count5 = 0;
            if(r5==r5)
            { count5++; }
            if(r5==r1)
            { count5++; }
            if(r5==r2)
            {count5++;}
            if(r5==r3)
            { count5++;}
            if(r5==r4)
            { count5++; }

            Console.WriteLine("frequency of digit 1: "+r1 +"is :"+count);
            Console.WriteLine("frequency of digit 2: "+r2+"is :"+count2);
            Console.WriteLine("frequency of digit 3: " +r3 +"is :"+count3);
            Console.WriteLine("frequency of digit 4: "+r4 +"is :"+count4);
            Console.WriteLine("frequency of digit 5: "+r5+"is :"+count5);
        }
    }
}
