using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Staticex
    {
       string accoundholder;
        string accountid;
       static int interest;
        static Staticex()
        {
            interest = 5;
        }
        public Staticex(string accountholder,string accountid)
        {
            this.accoundholder=accoundholder;
            this.accountid = accountid;
        }
        static void Main(string[] args)
        {
           Staticex s = new Staticex("sakshi","gfashdj");
            Console.WriteLine(Staticex.interest);
            Console.WriteLine(s.accountid);
        }
    }
}
