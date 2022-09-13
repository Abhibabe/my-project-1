using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Time
    {
        int hour;
        int minute;
        int sec;
        public void Settime()
        {
            Console.WriteLine("enter the hour");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine(  "enter the minute");
            minute = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sec ");
            sec = int.Parse(Console.ReadLine());

        }
        public void Showtime()
        {
            Console.WriteLine("hour" + hour);
            Console.WriteLine("minute" + minute);
            Console.WriteLine("sec" + sec);
        }
        public static void Main()
        {
            Time t = new Time();
            t.Settime();
            t.Showtime();
        }

    }
}
