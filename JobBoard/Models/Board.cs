using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Board
    {
        public Board()
        {
            JobPosts = new List<JobPost>();
        }

        public List<JobPost> JobPosts { get; set; }


    }
}
