using System;

namespace MoshIfExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the speedlimit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How fast was the car going?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK.");
            }
            else
            {
                const int KMOverSpeedLimit = 5;
                var points = (carSpeed - speedLimit) / KMOverSpeedLimit;
                if (points >= 12)
                {
                    Console.WriteLine("Disqualified");
                }
                else
                {
                    Console.WriteLine("Points lost: " + points);
                }
            }
        }
    }
}
