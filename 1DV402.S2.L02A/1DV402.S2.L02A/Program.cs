using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class Program
    {
        static void Main(string[] args)
        {                      
            // Test 1
            AlarmClock clock = new AlarmClock();
            ViewTestHeader("Test 1.\nTest av standardkonstruktorn.");
            string time = clock.ToString();
            Console.WriteLine(time);
            
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                ac.TickTock();
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}
