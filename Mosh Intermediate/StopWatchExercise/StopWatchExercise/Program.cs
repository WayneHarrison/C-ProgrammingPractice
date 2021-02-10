using System;

namespace StopWatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch application");
            var stopwatch = new StopWatch();
            while (true)
            {
                Console.WriteLine("Enter 'Start' to begin, 'Stop' to stop and 'Quit' to quit.");
                var input = Console.ReadLine().ToLower();
                if (input == "start")
                {
                    Console.WriteLine("Stopwatch Started.");
                    stopwatch.Start();
                }
                else if (input == "stop")
                {
                    Console.WriteLine("Stopwatch Stopped.");
                    Console.WriteLine(stopwatch.Stop().ToString("g"));
                    

                }
                else if (input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                }
            }
        }
    }
}
