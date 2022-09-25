using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    interface Cake
    {
        public void bake();
    }
    class Strawberry:Cake
    { 
        public void bake()
        {
            Console.WriteLine("strawberry");
        }
    }
    class Blackforest:Cake
    {
        public void bake()
        {
            Console.WriteLine("blackforest");
        }
    }
    class Cakebake
    {
        static void Main(string[] args)
        {
            Blackforest b = new Blackforest();
            b.bake();
        }
    }
}
