using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c); //c# has operator precedence, it follows BODMAS by default.
            Console.WriteLine(a > b); //Comparison operators are always true or false.
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b)); //Do not use double negative like this.
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a); //False, both need to be true to produce a true result.

        }
    }
}
