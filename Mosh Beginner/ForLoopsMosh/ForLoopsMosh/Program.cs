using System;

namespace ForLoopsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loops.");
            for (var i = 1; i <= 10; i ++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Foreach loops.");
            //foreach example.
            var name = "John Smith";
            //For each is much more efficient here, less code.
            //for (var ii = 0; ii < name.Length; ii++)
            //{
            //    Console.WriteLine(name[ii]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            //Easy way to iterate over a list.
            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //While Loops.
            Console.WriteLine("While Loops.");
            var iw = 0;
            while (iw <= 10)
            {
                if(iw%2 ==0)
                    Console.WriteLine(iw);
                iw++;
            }

            while (true)
            {
                Console.Write("Type your name:");
                var input =  Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;

            }
        }
    }
}
