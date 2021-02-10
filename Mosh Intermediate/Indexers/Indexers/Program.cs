using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Wayne";
            Console.WriteLine(cookie["name"]);
        }
    }
}
