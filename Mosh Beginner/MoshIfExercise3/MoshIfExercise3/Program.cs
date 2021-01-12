using System;

namespace MoshIfExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the image.");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the image.");
            var width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("This is a portrait image.");
            }
            else if (width > height)
            {
                Console.WriteLine("This is a landscape image");
            }
            else
            {
                Console.WriteLine("This image is a square.");
            }
        }
    }
}
