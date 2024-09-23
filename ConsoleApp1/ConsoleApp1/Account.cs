using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //abstract class and method
    public abstract class Account
    {
        public void msg()
        {
            Console.WriteLine("Welcome to ABC bank");
        }
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();

    }
    public class SAccount : Account
    {
        public override void balance()
        {
            Console.WriteLine("Balance in SAccount");
        }

        public override void deposit()
        {
            Console.WriteLine("deposit in SAccount");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from SAccount");
        }
    }
}
