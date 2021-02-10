using System;

namespace SocialMediaExercise
{
    
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostTime { get; private set; }
        public int VoteCount { get; private set; }

        private bool UpVoted;
        private bool DownVoted;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            PostTime = DateTime.Now;
            VoteCount = 0;
        }

        public void UpVote()
        {
            if (UpVoted)
            {
                throw new Exception("You  have already upvoted.");
            }
            else
            {
                VoteCount++;
                UpVoted = true;
                DownVoted = false;

            }
        }
        public void DownVote()
        {
            if (DownVoted)
            {
                throw new Exception("You  have already downvoted.");
            }
            else
            {
                VoteCount--;
                UpVoted = false;
                DownVoted = true;

            }
        }

    }
}