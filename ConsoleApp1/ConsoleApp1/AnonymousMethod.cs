using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Print_msg(string msg);
    internal class AnonymousMethod
    {
        public static void Invoke_method()
        {
            Print_msg print_Msg = delegate (string msg)
            {
                Console.WriteLine("Message: " + msg);
            };

            //msg
            print_Msg("Hello");
        }
    }
}
