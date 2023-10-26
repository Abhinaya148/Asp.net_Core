using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler:{e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler:{e}");
            }
        }
    }
}
