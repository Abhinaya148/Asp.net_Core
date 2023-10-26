using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a , b;
            int a = 0;
            try
            {
                int b = 45 / a;
                Console.WriteLine(b);
            }
            catch(AttemptToDivideByZero)
            {
                Console.WriteLine("");
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex}");
            }   
        }
    }
}
