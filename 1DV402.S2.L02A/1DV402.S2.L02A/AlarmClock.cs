using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class AlarmClock
    {
        // Declaring fields
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        // Encapsulating fields
        public int AlarmHour
        {
            get { return _alarmHour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                } 
                else{_alarmHour = value;}                
            }
        }
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set 
            { 
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                } else {_alarmMinute = value;}
            }
        }
        public int Hour
        {
            get { return _hour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                } else {_hour = value;}                 
            }
        }
        public int Minute
        {
            get { return _minute; }
            set 
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                else {_minute = value;}                 
            }
        }

        // Constructors
         public AlarmClock()
            :this(0, 0)
        {

        }
        public AlarmClock(int hour, int minute)
            :this(0, 0, 0, 0)
        {
            
        }
        public AlarmClock(int hour, int minute , int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        // Methods
        public bool TickTock()
        {
            if (Minute + 1 > 59)
            {
                Minute = 0;                
                if (Hour + 1 > 23)
                {
                    Hour = 0;
                }
                else
                {
                    Hour++;
                }
            }
            else
            {
                Minute++;
            }

            // Checking if time matches alarm time.
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1} ({2}:{3})", Hour, Minute.ToString("D2"), AlarmHour, AlarmMinute.ToString("D2"));
        }
    }
}
