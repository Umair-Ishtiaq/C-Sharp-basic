using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Students
    {
        //Data Member
        int stdid;
        string name;

        //Constructor
        public Students()
        {
            stdid = 10;
            name = "Herry";
        }

        //Member fun
       public void acceptstd()
        {
            Console.Write("Enter ID : ");
            stdid=int.Parse(Console.ReadLine());
            Console.Write("Enter name : ");
            name = Console.ReadLine();
        }
        public void displaystd()
        {
            Console.WriteLine("ID : " + stdid);
            Console.WriteLine("Name : "+name);
        }
    }
}
