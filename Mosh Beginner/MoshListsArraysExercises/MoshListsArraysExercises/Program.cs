using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace MoshListsArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name or press enter to quit.");

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) 
                    break;

                names.Add(input);
            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();

            Console.WriteLine("What is your name");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a unique number.");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You have already entered that number, try another.");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);

            var numbers2 = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or quit to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var unique = new List<int>();
            foreach (var number in numbers)
            {
                if(!unique.Contains(number))
                    unique.Add(number);
            }

            Console.WriteLine("Unique Numbers: ");
            foreach(var number in unique)
                Console.WriteLine(number);

            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma seperated numbers.");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                    
                }
                Console.WriteLine("Invalid.");
            }

            var numbers3 = new List<int>();
            
            foreach (var number in elements)
                numbers3.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                var min = numbers3[0];
                foreach (var number in numbers3)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numbers3.Remove(min);
            }
            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallest)
                Console.WriteLine(number);
        }
    }
}
