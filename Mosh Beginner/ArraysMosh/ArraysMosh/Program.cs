using System;

namespace ArraysMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 2,5,7,4,1,5};
            Console.WriteLine("Length: " + numbers.Length); //Get length of array.

            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4 is: " + index); //Arrays start at 0 so it's third.

            Array.Clear(numbers, 0, 2); //Sets certain elements to 0 as it's an int array, if boolean they become false, if strings clearing setting to null.

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var another = new int[3];
            Console.WriteLine("Copy method.");
            Array.Copy(numbers, another, 3);

            foreach (var v in another)
            {
                Console.WriteLine(v);
            }

            Array.Sort(numbers);
            Console.WriteLine("Sort Method");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(numbers);
            Console.WriteLine("Reverse method.");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
