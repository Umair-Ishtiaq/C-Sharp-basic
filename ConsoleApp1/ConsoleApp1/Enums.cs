using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Weekdays
    {
        Monday,// start from 0
        Tuesday,
        Wednesday, 
        Thursday,
        Friday,
        Saturday,
        Sunday // 6
    }
    internal class Enums
    {
        public void display()
        {
            Console.WriteLine(Weekdays.Monday);
            int day=(int)DayOfWeek.Monday;
            Console.WriteLine(day);
            Console.WriteLine(Weekdays.Thursday);
            Console.WriteLine(Weekdays.Wednesday);

        }
    }
}
