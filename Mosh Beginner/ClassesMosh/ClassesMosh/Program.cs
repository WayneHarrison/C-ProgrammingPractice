using System;
using System.Security.Cryptography.X509Certificates;
using ClassesMosh.Math;

namespace ClassesMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var wayne = new Person();
            wayne.fName = "Wayne";
            wayne.lName = "H";
            wayne.Introduce();

            Calculator calculator = new Calculator();
            var result= calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
