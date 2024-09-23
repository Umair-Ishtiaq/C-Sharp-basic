using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class PartialClass
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + this.EmpID);
            Console.WriteLine("Employee Name" + this.EmpName);
        }
    }
}
