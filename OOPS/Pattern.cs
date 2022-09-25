using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{/*12345
ABCD
123
AB
1
AB
123
ABCD
12345*/


    class Pattern
    {
        static void Main(string[] args)
        {
            {
                for (int k = 5; k >= 1; k--)
                {
                    for (int m = 1; m <= k; m++)
                    {
                        if (k == 1 || k == 3 || k == 5)
                        {
                            Console.Write(m);
                        }
                        else if (k == 2 || k == 4)
                        {
                            Console.Write((char)((char)(64 + m)));
                        }
                    }
                    Console.WriteLine();
                }
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i == 3 || i == 5)
                            {
                                Console.Write(j);
                            }
                            else if (i == 2 || i == 4)
                            {
                                Console.Write((char)((char)(64 + j)));
                            }
                        }
                        Console.WriteLine();
                    }
            }
        }
    }
}
