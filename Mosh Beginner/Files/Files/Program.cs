using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\WayneJnr\Videos\a.mp4";
            File.Copy(@"D:\Personal Files\Documents\Python Projects\Gawr Gura - a.mp4", @"C:\Users\WayneJnr\Videos\a.mp4", true);
            File.Delete(@"C:\Users\WayneJnr\Videos\a.mp4");
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists.");
            }

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

        }
    }
}
