using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Calculator
    {
        int a;
        int b;
        int c;
        public void readdata()
        {
            Console.WriteLine("Enter a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = int.Parse(Console.ReadLine());
        }
        public int add()
        {
            c = a + b;
            return c;
        }
        public int sub()
        {
            c = a - b;
            return c;
        }
        public int mul()
        {
            c = a * b;
            return c;
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.readdata();
            int sum = c.add();
            int Sub = c.sub();
            int Mul = c.mul();
            Console.WriteLine(sum);
            Console.WriteLine(Sub);
        }
    }
}
