using System;
using System.Collections.Generic;
using System.Text;
/*Design class Order (int ordered, String Orderdate, Customer cust, Item item)
Customer(int custid, String custname, Address address)
Address(String addr1, city, int pincode)
Item(int itemid, String itemname, int price)
Write constructors, properties in respective classes.*/

namespace OOPS
{
    class Order
    {
        int ordered;
        string orderdate;
        Customer cust;
        public Order()
        {

        }
        public Order(int ordered,string orderdate,Customer cust)
        {
            this.ordered = ordered;
            this.orderdate = orderdate;
            this.cust = cust;
        }
        public int Ordered
        {
            set { ordered = value; }
            get { return ordered; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get => orderdate;
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }
    }
    class Customer
    {
        int custid;
        string custname;
        Adress address;
        public Customer()
        {

        }
        public Customer(int custid,string custname,Adress address)
        {
            this.custname = custname;
            this.Custid = custid;
            this.address = address;
        }
        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Adress Adress
        {
            set { address = value; }
            get { return address; }
        }
    }
    class Adress
    {
        string address1;
        string city;
        int pincode;
        public Adress()
        {

        }
        public Adress(string address1,string city,int pincode)
        {
            this.address1 = address1;
            this.city = city;
            this.pincode = pincode;
        }
        public string Adress1
        {
            set { address1 = value; }
            get { return address1; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
        static void Main(string[] args)
        {
            Order o =new Order(200,"20/9",(new Customer(202,"sakshi",new Adress("warje","pune",411023))));
            Console.WriteLine(o.Ordered);
            Console.WriteLine(o.Orderdate);
            Console.WriteLine(o.Cust.Custid);
            Console.WriteLine(o.Cust.Custname);
            Console.WriteLine(o.Cust.Adress.address1);
            Console.WriteLine(o.Cust.Adress.city);
            Console.WriteLine(o.Cust.Adress.pincode);
        }
    }
}
