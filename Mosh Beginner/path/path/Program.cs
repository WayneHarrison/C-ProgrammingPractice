using System;
using System.IO;

namespace path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Pictures\0v2ofwkm7k041.jpg";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("Filename: " + Path.GetFileName(path)); 
            Console.WriteLine("Filename no extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
