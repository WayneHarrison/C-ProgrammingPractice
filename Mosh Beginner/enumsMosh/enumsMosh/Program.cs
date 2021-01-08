using System;

namespace enumsMosh
{
    public enum shippingMethods
    {
        RegAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = shippingMethods.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((shippingMethods)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod =  (shippingMethods)Enum.Parse(typeof(shippingMethods), methodName); //Parse a string to an enum
        }
    }
}
