using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{   class Actor
    {
        string actorname;
        long moviesdone;
        public Actor(string actorname,long moviesdone)
        {
            this.actorname = actorname;
            this.moviesdone = moviesdone;
        }
       
    }
    class movie
    {
        string moviename;
        string moviedirector;
        Actor a;
        public movie()
        {

        }
        public string Moviename
        {
            set { moviename = value; }
            get { return moviename; }
        }
        public string Moviedirector
        {
            set { moviedirector = value; }
            get { return moviedirector; }
        }
        private Actor A
        {
            set { a = value; }
            get { return a; }
        }
        static void Main(string[] args)
        {
            Actor a1 = new Actor("varun", 88);
            movie m = new movie();
            Console.WriteLine(  "write a movie name");
            string s = Console.ReadLine();
            m.Moviename = s;
            Console.WriteLine(s);
            m.Moviedirector = "karan johar";
            Console.WriteLine(m.Moviedirector);
            m.A = a1;
            Console.WriteLine();
        }
    }
}
