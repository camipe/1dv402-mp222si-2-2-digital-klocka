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
            //Running a series of test to check the class AlarmClock.
            
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
            ViewTestHeader("Test 4.\nStäller ett befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Run(clock, 13);
            Console.WriteLine();

            // Test 5
            clock.Hour = 6;
            clock.Minute = 12;
            clock.AlarmHour = 6;
            clock.AlarmMinute = 15;
            ViewTestHeader("Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter");
            Run(clock, 6);
            Console.WriteLine();

            // Test 6
            ViewTestHeader("Test 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            // Testing clock.Hour
            try
            {
                clock.Hour = 24;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23.");                
            }
            // Testing clock.Minute
            try
            {
                clock.Minute = 60;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Minuten är inte i intervallet 0-59.");
            }
            // Testing clock.AlarmHour
            try
            {
                clock.AlarmHour = 24;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23.");
            }
            // Testing clock.AlarmMinute
            try
            {
                clock.AlarmHour = 60;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet 0-59.");
            }
            Console.WriteLine();

            // Test 7
            ViewTestHeader("Test 7.\nTestar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            //Testing Hour/Minute constructor
            try
            {
                clock = new AlarmClock(49, 39);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen/Minuten är inte i intervallet 0-23/0-59");
            }
            // Testing AlarmHour/AlarmMinute constructor
            try
            {
                clock = new AlarmClock(35, 70);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Alarmtimmen/Alarmminuten är inte i intervallet 0-23/0-59");
            }
            Console.WriteLine();

        }

        // Method that runs the AlarClock.Ticktock method and if it returns true prints the special alarm message else it justs prints the time with no formatting.
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ac.ToString() + "\tBEEP! BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else {Console.WriteLine(ac.ToString());}
            }
        }

        // Methods that prints messages (in different styles).
        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}
