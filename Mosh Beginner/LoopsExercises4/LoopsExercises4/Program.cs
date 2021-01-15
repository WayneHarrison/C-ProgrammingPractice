using System;

namespace LoopsExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10.");

            var number = new Random().Next(1, 10);
            Console.WriteLine(number);

            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the number:");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You guessed right!");
                    return;
                }
            }

            Console.WriteLine("You lost.");
        }
    }
}
