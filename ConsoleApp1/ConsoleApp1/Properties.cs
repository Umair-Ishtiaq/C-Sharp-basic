using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Properties
    {
        string name;
        string cname;
        int age;
        //auto
        int CNIC {  get; set; }
        public int Age
        {
            get{return age; }
            set 
            {
                if (value < 18)
                    throw new ArgumentException("Invalid Age");
            age = value;
            }

        }
        public Properties()
        {
            cname = "ABC Company";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Cname
        {
            get { return cname; }
        }

    }
}
