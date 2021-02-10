using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1997, 3, 30));
            Console.WriteLine(person.Age);
        }
    }
}
