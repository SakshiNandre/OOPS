using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Student
    {
        string studentname;
        int passoutyear;
        Batch b;
        public Student()
        {

        }
        public string Studentname
        {
            set { studentname = value; }
            get { return studentname; }
        }
        public int Passoutyear
        {
            set { passoutyear = value; }
            get { return passoutyear; }
        }
        public Batch B
        {
            set { b = value; }
            get { return b; }
        }
        public Student(string Studentname, int Passoutyear,Batch B)
        {
            this.studentname = Studentname;
            this.passoutyear = Passoutyear;
            this.b = B;
        }
    }
    class Batch
    {
        string batchname;
        string technology;
        Trainer t;
        public Batch()
        {

        }
        public string Batchname
        {
            set { batchname = value; }
            get { return batchname; }
        }
        public string Technology
        {
            set { technology = value; }
            get { return technology; }
        }
        public Trainer T
        {
            set { t = value; }
            get { return t; }
        }
        public Batch(string Batchname, string Technology, Trainer T)
        {
            this.batchname = Batchname;
            this.technology = Technology;
            this.t = T;
        }
    }
    class Trainer
    {
        string trainername;
        string qualification;
        int experience;
        public Trainer()
        {

        }
        public string Trainername
        {
            set { trainername = value; }
            get { return trainername; }
        }
        public Trainer(string trainername, string qualification, int experience)
        {
            this.trainername = trainername;
            this.qualification = qualification;
            this.experience = experience;
        }

        static void Main(string[] args)
        {
            Trainer t1 = new Trainer();
            t1.trainername = "Deepa mam";
            t1.qualification = "M.E";
            t1.experience = 10;
            Batch b1 = new Batch("w","c",t1);
            b1.T = t1;
            Student s1 = new Student();
            s1.Studentname = "sakshi";
            s1.Passoutyear = 2022;
            s1.B = b1;
        }
    }
}
