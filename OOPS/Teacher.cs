using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    abstract class Teacher
    {
        //Tid,Tname,MobileNo
        string tid;
        string tname;
        long mobileno;
        public Teacher()
        {

        }
        public Teacher(string tid,string tname,long mobileno)
        {
            this.tid = tid;
            this.tname = tname;
            this.mobileno = mobileno;
        }
        abstract public void Salary();
    }
    class Hourlybased:Teacher
    {
        int rate_per_hr;
	    int hrs;
        public Hourlybased()
        {

        }
        public Hourlybased(string tid, string tname, long mobileno,int rate_per_hr,int hrs):base(tid,tname,mobileno)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;
        }
       public override void Salary()
        {
            Console.WriteLine("Hourly teacher Salry "+hrs*rate_per_hr);
        }
    }
    class SalaryBased:Teacher
    {
        int salary;
        public SalaryBased()
        {

        }
        public SalaryBased(int salary):base()
        {

        }
        

        public override void Salary()
        {
            throw new NotImplementedException();
        }
    }
    class Teachertest
    {
        static void Main(string[] args)
        {
            Teacher h = new Hourlybased();
          Teacher s = new SalaryBased();
        }
    }
}
