using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class ToStr
    {
        string name;
        string age;
        public ToStr(string name,string age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Age
        {
            set { age = value; }
            get { return age; }
        }
        public override string ToString()
        {
            return "name: " + Name+" " + "age: " + Age;
        }
    }
    class TOSTRING
    {
        static void Main(string[] args)
        {
            ToStr t = new ToStr("sakshi", "22");
            Console.WriteLine(t);
        }
    }
}
