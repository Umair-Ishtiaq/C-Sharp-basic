using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class intExtention
    {
        public static bool IsGreaterThan(this int x, int value)
        {
            return x > value;
        }
    }
}
