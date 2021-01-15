using System;

namespace LoopsExercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (var i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
