using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Arr
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 number");
            for (int i=0;i<5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    class Arr1
    {
        static void Main(string[] args)
        {
            char[] b = new char[5];
            Console.WriteLine("Enter 5 char");
            for (int j = 0; j < 5; j++ )
            {
                b[j] = char.Parse(Console.ReadLine());
            }
            for(int j=0;j<5;j++)
            {
                Console.WriteLine(b[j]);
            }
        }

    }
    class countoddeven
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

        }
    }
    class checkdivisibleby5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            Console.WriteLine("enter 5 numbers");
            for (int i = 0; i < n; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
                if (m[i] % 5 == 0)
                {
                    // Console.WriteLine("divisible by 5 " +i+5);
                    m[i] = m[i] ;
                    Console.WriteLine(m[i]);
                }
                else
                {
                    Console.WriteLine("Not divisible by 5");
                }
            }
        }
    }
    class combinearray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5 ,6 ,7 ,8};
            int[] c = new int[a.Length+b.Length];
           // int c = 0;
            for(int i=0;i<c.Length;i++)
            {
                if (i < a.Length)
                {
                    c[i] = a[i];
                }
                else
                    c[i] = b[i - a.Length];
            }
            for (int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]+" ");
            }
        }
    }
    class alternatearray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 7, 9 };
            int[] b = { 2, 4, 6, 8, 10 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
          /*  for (int i = 0; i < c.Length;)
            {
                c[i] = a[k];
                i++;
                c[i] = b[k];
                i++;

                k++;
            }*/

            int j = 0;
            for(int i=0;i<b.Length;i++)
            {
                c[j] = a[i];
                j++;
                c[j] = b[i];
                j++;


            }
            for (int i = 0; i < c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
    class small_longarray
    {
        static void Main(string[] args)
        {
            int[] k ={ 10,20,30,40};
            int[] e ={ 50, 60, 70, 80, 90, 5, 15 };
            int[] h = new int[k.Length + e.Length];
            int n = 0;
            for (int s=0;s<h.Length;)
            {
                //common element
                if(n<k.Length && n<e.Length)
                {
                    h[s] = k[n];
                    s++;
                    h[s] = e[n];
                    s++;
                }
                else if(n<e.Length)
                {
                    h[s] = e[n];
                    s++;
                }
                n++;
            }
            for (int s = 0; s < h.Length; s++)
            {
                Console.WriteLine(h[s]);
            }
        }
    }
    //WAP to add elements to single dimensional int array and print elements from 1D array
    class add_array_element
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a length of array");
            int c = int.Parse(Console.ReadLine());
            int[] v = new int[c];
            Console.WriteLine("Enter the element of array ");
            for (int i=0;i<)
        }
    }
}
