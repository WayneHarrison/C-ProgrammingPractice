using System;

namespace ClassesMosh
{
    public class Person
    {
        public string fName;
        public string lName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + fName +" " + lName);
        }
    }
}