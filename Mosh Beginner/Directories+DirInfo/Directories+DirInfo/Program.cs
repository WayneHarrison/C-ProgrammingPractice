using System;
using System.IO;

namespace Directories_DirInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\folder1";
            Directory.CreateDirectory(path);

             var files = Directory.GetFiles(@"D:\Personal Files\Pictures\Anime Reaction Pictures\Siege", "*.png*",
                SearchOption.TopDirectoryOnly);
             foreach (var file in files)
             {
                 Console.WriteLine(file);   
             }

             var directories = Directory.GetDirectories(@"D:\Personal Files\Pictures\Anime Reaction Pictures\Siege",
                 "*.*", SearchOption.AllDirectories);
             foreach(var directory in directories)
                 Console.WriteLine(directory);

             Directory.Exists("...Path");

             var directoryInfo = new DirectoryInfo("...path");
             directoryInfo.GetFiles();
             directoryInfo.GetDirectories();
        }
    }
}
