using System;
using System.Collections.Generic;
/*Person(int id, String name, Vehicle v)
Vehicle(int vid, String vname)*/

namespace OOPS
{
    class Person
    {
        int id;
        string name;
        Vehicle v;
        public Person()
        {

        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Vehicle V
        {
            set { v = value; }
            get { return v; }
        }
    }
    class Vehicle
    {
        int vid;
        string vname;
        public Vehicle()
        {

        }
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }
        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 12352;
            p.Name = "sadsb";
            Vehicle v1 = new Vehicle();
            v1.Vid = 5432648;
            v1.Vname = "vghk";
            p.V = v1;
            
        }
    }
}
