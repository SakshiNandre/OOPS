using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Time
    {
        int hour;
        int min;
        int sec;
        public void settime(int h,int m,int s)
        {
            hour = h;
            min = m;
            sec = s;
        }
        public void showtime()
        {
            Console.WriteLine("hour "+hour);
            Console.WriteLine("Min "+min);
            Console.WriteLine("Sec "+sec);
        }
        static void Main(string[] args)
        {
            Time t = new Time();
            t.settime(5, 60, 80);
            t.showtime();
        }
    }
}
