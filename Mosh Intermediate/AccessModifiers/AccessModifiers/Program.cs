﻿using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1997, 3,30));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
