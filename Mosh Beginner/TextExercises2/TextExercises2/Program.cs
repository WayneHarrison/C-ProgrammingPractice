using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TextExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time:");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Time was OK.");
                else
                    Console.WriteLine("Invalid Time.");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid Time.");
            }

            //Program 2

            Console.WriteLine("Please enter a few words.");
            var input2 = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input2))
            {
                Console.WriteLine("Error.");
                return;
            }

            var varName = "";
            foreach (var word in input2.Split(' '))
            {
                var pascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                varName += pascalCase;
            }

            Console.WriteLine(varName);

            //Program 3
            Console.WriteLine("Please type a sentence.");
            var input3 = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' }) ;
            var vowelCount = 0;
            foreach (var character in input3)
            {
                if (vowels.Contains(character))
                    vowelCount++;
            }

            Console.WriteLine("There are " + vowelCount + " vowels.");
        }
    }
}
