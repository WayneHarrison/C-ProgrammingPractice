using System;
using System.IO;

namespace PathExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string largestword = "";
            var i = 0;
            var path = @"C:\Users\WayneJnr\Documents\hello.txt";
            string[] lines = File.ReadAllLines(path);

            var words = string.Join(" ", lines);

            string[] indWords = words.Split(" ");
           


            foreach(string word in indWords)
            {
                i++;
            }
            Console.WriteLine("There are " + i + " words.");

            for (int j = 0; j < indWords.Length; j++)
            {
                if (largestword.Length < indWords[j].Length)
                {
                    largestword = indWords[j];
                }
            }

            Console.WriteLine("The largest word is: " + largestword);
           
            
        }
    }
}
