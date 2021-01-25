using System;

namespace DateTimeMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2016, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
           /* Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);*/

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));

            //Time Spans
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
            //properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Addition Example "  + timeSpan.Add(TimeSpan.FromMinutes(6)));
            Console.WriteLine("Subtraction Example "  + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString

            Console.WriteLine("ToString" + timeSpan.ToString());

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
