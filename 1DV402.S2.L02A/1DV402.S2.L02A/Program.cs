﻿using System;
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
            Console.WriteLine();

            // Test 2
            clock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2.\nTest av standardkonstruktorn med två parametrar, (9, 42)");
            time = clock.ToString();
            Console.WriteLine(time);
            Console.WriteLine();

            // Test 3
            clock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3.\nTest av standardkonstruktorn med fyra parametrar, (13, 24, 7, 35)");
            time = clock.ToString();
            Console.WriteLine(time);
            Console.WriteLine();

            // Test 4
            clock.Hour = 23;
            clock.Minute = 58;
            ViewTestHeader("Test 2.\nStäller ett befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Run(clock, 13);
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                ac.TickTock();
                Console.WriteLine(ac.ToString());
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
