using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models
{
    // Interface to separate data retrieval from the controller
    public interface IJobPostRepository
    {
        IEnumerable<JobPost> JobPosts { get; }

        void SaveJobPost(JobPost jobPost);
    }
}
