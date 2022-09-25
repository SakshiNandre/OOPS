using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Parent
    {
        public  void m1()
        {
            Console.WriteLine("i am in parent m1");
        }
    }
    class Child:Parent
    {
        public  void m1()
        {
            Console.WriteLine("i am in child m1");
        }
    }
    class test1
    {
        static void Main(string[] args)
        {
           // Parent p = new Parent();
           // Child c = new Child();
           // p.m1();
            Parent pp = new Child();
            pp.m1();
           // Console.WriteLine(pp);
        }
    }
}
