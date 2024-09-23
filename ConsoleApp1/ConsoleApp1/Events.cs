using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //publisher model
    internal class Events
    {
        //Declare delegate
        public delegate void deledate_odd();
        //declare eent
        public event deledate_odd event_odd;
        public void addition()
        {
            int n1=100; int n2=2043;
            int result = n1+n2;
            Console.WriteLine(result);
            if(result%2 != 0 && event_odd != null)
            {
                //Raised event
                event_odd();
            }
        }
    }
}
