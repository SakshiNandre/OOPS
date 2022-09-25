using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class A
    {
        int i;
        public A()
        {
            Console.WriteLine("i am in A");
        }
        public A (int i)
        {
            this.i = i;
            Console.WriteLine("in a parameterised ");
        }
    }
    class B:A
    {
        int j;
        public B()//:base(10)
        {
            Console.WriteLine("i am B");
        }
        public B(int i,int j):base(i)
        {
            this.j = j;
            Console.WriteLine("in child parameterised");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            B b = new B(10,50);
        }
    }
}
