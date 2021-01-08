using System;

namespace StringsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Wayne";
            var lastName = "H";

            var fullName = firstName + " " + lastName;

            var fName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "James", "Josef"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look at the following paths
c:\folder1\folder2";
            Console.WriteLine(text);
        }
    }
}
