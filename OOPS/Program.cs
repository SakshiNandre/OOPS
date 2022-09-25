using System;

namespace OOPS
{   
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5 ;i++)
            {   
                for(int space=1;space<=5-i;space++)
                {
                    Console.Write(" ");
                }
                for (int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int k=5;k<=9;k++)
            {   
                for (int space =1;space<9-k;space++)
                {
                    Console.Write(" ");
                }
                for (int d=5;d<=k;d++)
                {
                    Console.Write(d);
                   // Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}
