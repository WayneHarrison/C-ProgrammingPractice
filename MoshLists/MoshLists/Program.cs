using System;
using System.Collections.Generic;

namespace MoshLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4}; //List Definition

            numbers.Add(1); //Lists allow you to add as many objects as you like.
            numbers.AddRange(new int[]{5,6,7}); //Addition of a range of numbers.

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); //Get first index of a number
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); //Get last index of a number.

            Console.WriteLine("Count: "+ numbers.Count); //Counts all numbers in list

            numbers.Remove(1); //removes an item.

            for (var i = 0; i < numbers.Count; i++) //For loop to remove items from list, foreach causes an exception.
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear(); //Removes all elements from the list.
        }
    }
}
