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

        public void SaveJobPost(JobPost jobPost)
        {
            if (jobPost.JobPostID == 0)
            {
                context.JobPosts.Add(jobPost);
            } else
            {
                JobPost dbEntry = context.JobPosts
                    .FirstOrDefault(jp => jp.JobPostID == jobPost.JobPostID);
                if (dbEntry != null) {
                    dbEntry.Title = jobPost.Title;
                    dbEntry.City = jobPost.City;
                    dbEntry.Description = jobPost.Description;
                    dbEntry.CloseDate = jobPost.CloseDate;
                    dbEntry.PostDate = jobPost.PostDate;
                }
            }
            context.SaveChanges();
        }
    }
}
