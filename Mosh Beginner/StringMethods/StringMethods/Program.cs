using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Uein Harison ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName);
            //Split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Uein", "Wayne"));
            //Is null or whitespace checking
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");
            //Conversion to numbers/bytes.
            var input = "25";
            var age = Convert.ToByte(input);
            Console.WriteLine(age);
            //Convert numbers to strings.
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
