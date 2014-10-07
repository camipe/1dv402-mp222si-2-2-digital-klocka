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
             AlarmClock Clock = new AlarmClock();
             Console.WriteLine("Hour: {0}", Clock.Hour);
             Console.WriteLine("Minute: {0}", Clock.Minute);

             for (int i = 0; i < 1500; i++)
             {              

                Clock.TickTock();
                Console.WriteLine(Clock.ToString());
             }

        }
    }
}
