using JobBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Data
{
    public class EFJobPostRepository : IJobPostRepository
    {
        private ApplicationDbContext context;

        public EFJobPostRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<JobPost> JobPosts => context.JobPosts;
    }
}
