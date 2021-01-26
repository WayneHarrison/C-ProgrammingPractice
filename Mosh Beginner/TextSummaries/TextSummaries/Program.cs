using System;
using System.Collections.Generic;

namespace TextSummaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long sentence.";
            var summary = StringUtility.Summarize(sentence);
            Console.WriteLine(summary);

        }

    }
}
