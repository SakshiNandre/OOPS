using System;
using System.Collections.Generic;
using System.Text;
/*Write a program with ‘Application’ class in package named mypack containing properties like version, technology used, Developer as 
 * contained object and behaviors like install(),uninstall().                                                                                              

 Developer class has properties, devName, devExperience,skills and methods debugApp(),integrateCode(). Application class 
further used to create ‘DesktopApplication’ and ‘WebApplication’ classes in same namespace.
 Also it is used for ‘MobileApplication’ class creation in different namespace. Do appropriate utilization of base
keyword in creation of respective class objects and show details of each.	
*/
namespace OOPS
{
    class Application
    {
        string version;
        string technology_used;
        Developer d;
        
        public string Version
        {
            set { version = value;}
            get { return version; }
        }
        public string Technology_used
        {
            set { technology_used = value; }
            get { return technology_used; }
        }
        public Developer D
        {
            set { d = value; }
            get { return d; }
        }
        public void install()
        {

        }


        public void uninstall()
        {

        }
    }
    class Developer
    {
        string devname;
        int devExperience;
        string skills;
        public string Devname
        {
            set { devname = value; }
            get { return devname; }
        }
        public int DevExperience
        {
            set { devExperience = value; }
            get { return devExperience; }
        }
        public string Skills
        {
            set { skills = value; }
            get { return skills; }
        }
    }
}
