using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculation
    {
        public void calculate(int num1,int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occure");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Always execute");
                Console.WriteLine(result);

            }
        }

        public void FromUser_calculate()
        {
            int num1, num2;
            int result = 0;
            try
            {
                Console.Write("Enter 1st num : ");
                num1=int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd num : ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occure");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Always execute");
                Console.WriteLine(result);

            }
        }
    }
}
