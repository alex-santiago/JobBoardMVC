using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models.ViewModels
{
    // Class to transfer Job Posts information and Pagination to the view
    public class JobPostsListViewModel
    {
        public IEnumerable<JobPost> JobPosts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
