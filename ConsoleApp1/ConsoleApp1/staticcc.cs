using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class staticcc
    {
        static int count = 0;
        static staticcc()//static constructor
        {
            count = 0;
        }

        //methods
        public static int inc()
        {
            count++;
            return count;
        }
        public static int dec()
        {
            count--;
            return count;
        }


    }
}


