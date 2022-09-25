using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Pen
    {
        string penbrand;
        int price;
        string inkcolour;
        public Pen(string  a, string b)
        {

        }
        public Pen(string penbrand,int price, string inkcolour)
        {
            this.penbrand = penbrand;
            this.price = price;
            this.inkcolour = inkcolour;
        }
    }
    class Compass
    {
        string compassbrand;
        int price;
        Pen p;
        public Compass()
        {

        }
        public string Compassbrand
        {
            set { compassbrand = value; }
            get { return compassbrand; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        private Pen P
        {
           set { p = value; }
            get { return p; }
        }
        static void Main(string[] args)
        {
            Compass c1 = new Compass();
            c1.compassbrand = "sakshi";
            c1.Price = 200;
            Pen p1 = new Pen("Trimax", 45, "red");
            c1.P = p1;
        }
    }
}
