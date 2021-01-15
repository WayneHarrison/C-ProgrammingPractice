using System;

namespace LoopsExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter numbers or type ok to exit.");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("The sum of all numbers entered is: " +sum);
        }
    }
}
