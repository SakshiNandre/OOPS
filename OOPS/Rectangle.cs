using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Rectangle
    {
        int length, breadth, area, perimeter;
        public void input()
        {
            Console.WriteLine("Enter length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            perimeter = 2 * (length + breadth);
            area = length * breadth;
        }
        public void display()
        {
            Console.WriteLine("perimeter is" + perimeter);
            Console.WriteLine("Area of rectangle is " + area);
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.input();
            r.calculate();
            r.display();
        }
    }
}
