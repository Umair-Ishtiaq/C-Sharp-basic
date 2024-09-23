using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Imanage
    {
        void deposit();
        void withdraw();
        void balance();

    }
    internal interface Interface1
    {
        void openacc();
        void closeacc();
    }
    public class Savacc : Interface1,Imanage
    {
        public void balance()
        {
            Console.WriteLine("Balance in SAccount");
        }

        public void closeacc()
        {
            Console.WriteLine("close saving Account");

        }

        public void deposit()
        {
            Console.WriteLine("Deposit in SAccount");
        }

        public void openacc()
        {
            Console.WriteLine("open saving Account");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from SAccount");
        }
    }
}
