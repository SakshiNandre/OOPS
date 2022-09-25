using System;
using System.Collections.Generic;
using System.Text;
//0,1,1,2,3,5,8,13,21,34
namespace OOPS
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
    class square
    {     //1 4 9 16 25 36
        static void Main(string[] args)
        {
            Console.WriteLine("enter end point");
            int n = int.Parse(Console.ReadLine());
            int sum;
            for (int i=1;i<=n;i++)
            {
                sum = i * i;
                Console.Write(sum+" ");
            }
        }
    }
    class Series
    { //0,3,8,15,24,35
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 3;
            Console.WriteLine("Enter end point:");
            int k = int.Parse(Console.ReadLine());
            for (int i=1;i<=k;i++)
            {
                Console.WriteLine(i * i - 1);
            }
        }
    }
}

