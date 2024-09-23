using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Class1: Students
    {
        float oMarks;
        float sMarks;
        public void acceptstd()
        {
            base.acceptstd();
            Console.Write("Enter objective marks: ");
            oMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter subjective marks: ");
            sMarks = float.Parse(Console.ReadLine());
        }
        public void displaystd()
        {
            base.displaystd();
            Console.WriteLine("Objective marks : " + oMarks);
            Console.WriteLine("Subjective marks : " + sMarks);
        }
    }
}
