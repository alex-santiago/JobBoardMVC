using JobBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Data
{
    // Temporary class to simulate data repository and provide information during development
    public class FakeJobPostRepository /*: IJobPostRepository*/
    {
        // Class that implements the interface that will return the listing of job posts
        public IEnumerable<JobPost> JobPosts => new List<JobPost>
        {
            new JobPost {
                JobPostID =1, Title = "Full Stack Developer",
                AddressLine1 = "101-270 3RD ST W",
                AddressLine2 = "",
                City = "North Vancouver",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                PostalCode = "V7M 1G1",
                StateCode = "BC",
                PostDate = DateTime.Now
            },
            new JobPost {
                JobPostID =2, Title = "Front-end Developer",
                AddressLine1 = "3696 Carnavon AVE",
                AddressLine2 = "",
                City = "North Vancouver",
                Description = "Lorem ipsum dolor. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                PostalCode = "V7N 1M1",
                StateCode = "BC",
                PostDate = DateTime.Now
            }
        };
    }
}
