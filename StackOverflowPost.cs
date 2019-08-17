using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesSection2
{
    class StackOverflowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        private int vote;

        public StackOverflowPost(string title, string description) 
        {
            this.Title = title;
            this.Description = description;
            this.Created = DateTime.Now;
        }

        public void Upvote()
        {
            vote++;
        }

        public void Downvote()
        {
            vote--;
        }

        public int GetVote()
        {
            return vote;
        }
    }
}
