using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ProceduralProgramming
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

            var isConsecutive = IsConsecutive(numbers);
            

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


            Console.WriteLine(IncludesDuplicates(numbers2) ? "Duplicate" : "No Duplicates.");

            //Prog 3
            Console.WriteLine("Enter time:");
            var input3 = Console.ReadLine();
            Console.WriteLine(IsValidTime(input3) == true ? "Valid Time" : "Invalid Time.");

            //prog 4
            Console.WriteLine("Please enter a few words.");
            var input4 = Console.ReadLine();
            Console.WriteLine(PascalCaseName(input4));

            //prog 5
            Console.WriteLine("Please type a sentence.");
            var input5 = Console.ReadLine().ToLower();
            

            Console.WriteLine("There are " + GetNumberOfVowels(input5) + " vowels.");
        }

        public static Boolean IsConsecutive(List<int> numbers)
        {
            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    isConsecutive = false;
                    break;
                }
            }

            return isConsecutive;
        }

        public static Boolean IncludesDuplicates(List<int> numbers2)
        {
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

            return includesDupes;
        }

        public static bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;
            
            var components = time.Split(':');
            if (components.Length != 2)
                return false;

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);
                
                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }

        public static string PascalCaseName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return "";
            }

            var varName = "";
            foreach (var word in name.Split(' '))
            {
                var pascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                varName += pascalCase;
            }

            return varName;
        }

        public static int GetNumberOfVowels(string userInput)
        {
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vowelCount = 0;
            foreach (var character in userInput)
            {
                if (vowels.Contains(character))
                    vowelCount++;
            }

            return vowelCount;
        }

        
    }
}
