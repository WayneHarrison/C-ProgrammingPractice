using System;

namespace MoshIfExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter a number between 1 and 10.");
            var userInput = Console.ReadLine();

            if(Int32.Parse(userInput) <= 10 && Int32.Parse(userInput) >= 1)
            {
                Console.WriteLine("That is a number between one and ten.");
            }
            else
            {
                Console.WriteLine("That is not a number between one and ten.");
            }

        }
    }
}
