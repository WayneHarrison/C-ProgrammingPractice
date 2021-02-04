using System;

namespace Classes
{

    public class Person
    {
        public string name;

        public void introduce(string to)
        {
            Console.WriteLine("Hi, {0}, I am {1}", to, name);
        }

        public Person Parse(string str)
        {
            var person = new Person();
            person.name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var p = person.Parse("John");
            person.name = "Jack";
            person.introduce("Wayne");
            p.introduce("Wayne");
        }
    }
}
