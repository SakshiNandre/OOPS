using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Bank
    {
        string bankname;
        string branch;
        string address;
        string ifsc;
        public void accept()
        {
            Console.WriteLine("in accept");
        }
    }
    class HDFC:Bank
    {
        float roi;
        static void Main(string[] args)
        {
            HDFC H = new HDFC();
            H.accept();
        }
    }
}
