using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//declearing delegate
delegate int CalculateDelegate(int num);
namespace ConsoleApp1
{

    internal class Deligatess
    {
        static int number = 100;
        public static int addition(int num)
        {
            number = number + num;
            return number;
        }
        public static int multipy(int num)
        {
            number = number * num;
            return number;
        }
        public static int getnum()
        {
            return number;
        }
            

    }
}
