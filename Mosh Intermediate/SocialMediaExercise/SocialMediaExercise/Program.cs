using System;

namespace SocialMediaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Title test", "The description");
            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description:" + post.Description);
            Console.WriteLine("Date created: " + post.PostTime);
            Console.WriteLine("Vote count: " + post.VoteCount);
            post.DownVote();
            Console.WriteLine("Vote count: " + post.VoteCount);
            post.UpVote();
            Console.WriteLine("Vote count: " + post.VoteCount);
        }
    }
}
