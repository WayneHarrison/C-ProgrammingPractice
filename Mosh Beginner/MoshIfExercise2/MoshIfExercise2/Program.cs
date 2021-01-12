using System;
using System.Net.Http.Headers;

namespace MoshIfExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers.");
            Console.WriteLine("Number 1: ");
            var fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            var sNumber = Convert.ToInt32(Console.ReadLine());

            var maxNum = (fNumber > sNumber) ? fNumber : sNumber;
            Console.WriteLine("Maximum is " + maxNum);

            if (fNumber >sNumber)
            {
                Console.WriteLine("The first number ({0}) is the biggest ", fNumber);
            }
            else
            {
                Console.WriteLine("The second number ({0}) is the biggest ", sNumber);
            }
        }
    }
}
