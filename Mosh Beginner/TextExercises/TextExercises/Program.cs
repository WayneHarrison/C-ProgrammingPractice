using System;
using System.Collections.Generic;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 1");
            Console.WriteLine("Please enter some numbers separated by -: ");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Is not consecutive";
            Console.WriteLine(message);
            //prog 2
            Console.WriteLine("Program 2");

            Console.WriteLine("Write some numbers separated by - : ");

            var input2 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input2))
                return;

            var numbers2 = new List<int>();
            foreach (var number in input2.Split('-'))
            {
                numbers2.Add(Convert.ToInt32(number));
            }

            var uniqueNumbers = new List<int>();
            var includesDupes = false;
            foreach (var number in numbers2)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    includesDupes = true;
                    break;
                }
            }
            if (includesDupes)
                Console.WriteLine("Duplicate");



        }
    
    }
}
