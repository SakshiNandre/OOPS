using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    //*
    //**
    //***
    //****
    //*****
    class Practice
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //*****
            //****
            //***
            //**
            //*
            for (int y = 5; y >= 1; y--)
            {
                for (int z = 1; z <= y; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //1
            //12
            //123
            //1234
            //12345
            for (int h = 1; h <= 5; h++)
            {
                for (int o = 1; o <= h; o++)
                {
                    Console.Write(o);
                }
                Console.WriteLine();
            }
            //print a to z
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine(ch);
            }
            //print prime numbers from 1 to 100

            int count = 0;
            Console.WriteLine("Prime numbers between 1 and 100 are: ");

            for (int i = 1; i < 101; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i + "  ");
                    }
                }
            }
            //    1
            //   2 3 
            //  4 5 6
            // 7 8 9 10
            for (int g=1;g<=4;g++)
            {
                for (int space=1;space<=4-g;space++)
                {
                    Console.Write(" ");
                }
                for (int r=1;r<=g;r++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
            int r1;
            int s = 0;
            Console.WriteLine("enter a number to do sum of even no");
            int n1 = int.Parse(Console.ReadLine());
            while (n1!=0)
            {
                r1= n1 % 10;
                if (r1%2==0)
                {
                    s = s + r1;
                }
                n1 = n1 / 10;
            }
            Console.WriteLine(s);
        }
    }
    class BinaryNo
    {
        public bool checkbinary(int num)
        {
            if (num ==0 || num==1 || num<0)
            {
                return false;
            }
           // int rem1;
            while (num !=0)
            {
                if (num%10>1)
                { return false; }
                num = num / 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            BinaryNo b = new BinaryNo();
            Console.WriteLine("Enter a no to check binary");
            int n = int.Parse(Console.ReadLine());
            bool c = b.checkbinary(n);
            Console.WriteLine(c);
        }
    }
    class pattern1
    {
        static void Main(string[] args)
        {
            for (int i=4;i<=1;i--)
            {
                for (int k=1;k<=4;k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int L=1;L<=6;L++)
            {

            }
        }
    }
}
