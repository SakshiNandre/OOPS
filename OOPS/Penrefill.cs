using System;
using System.Collections.Generic;
using System.Text;
/*A Pen contains variables Refill r, int capLength and  String brand. 
	Refill has variables inkColor, length and Nib (tip).
	 Nib has variables materialType and width. 
	Create a Java class structure for above.*/

namespace OOPS
{
    class Penrefill
    {
        int caplength;
        string brand;
        Refill r;
        public Penrefill()
        {

        }
        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
        public Penrefill(int caplength,string brand,Refill r)
        {
            this.caplength = caplength;
            this.brand= brand;
            this.r = r;
        }
    }
    class Refill
    {
        string inkcolour;
        int length;
        Nib n;
        public Refill()
        {
            
        }
        public string Inkcolour
        {
            set { inkcolour = value; }
            get { return inkcolour; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public Nib N
        {
            set { n = value; }
            get { return n; }
        }
        public Refill(string inkcolour,int length,Nib n)
        {
            this.inkcolour = inkcolour;
            this.length = length;
            this.n = n;
        }
    }
    class Nib
    {
        string materialtype;
        int width;
        public Nib()
        {

        }
        public string Materialtype
        {
            set { materialtype = value; }
            get { return materialtype; }
        }
        public int Width
        {
            set { width = value; }
            get { return width; }
        }
        public Nib(string materialtype,int width)
        {
            this.materialtype = materialtype;
            this.width = width;

        }
        static void Main(string[] args)
        {
            Penrefill p = new Penrefill(20,"cello",(new Refill("black", 20,new Nib("plastic", 20))));
            Console.WriteLine(p.Brand);
            Console.WriteLine(p.Caplength);
            Console.WriteLine(p.R.N.materialtype);
        }
    }
}
