using JobBoard.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Data
{
    public static class SeedData
    {

        public static void InitializeDB(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.JobPosts.Any())
            {
                context.JobPosts.AddRange(
                    new JobPost
                    {
                        JobPostID = 1,
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "North Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 5, 30)
                    },
                    new JobPost
                    {
                        JobPostID = 2,
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 2)
                    },
                    new JobPost
                    {
                        JobPostID = 3,
                        Title = "Front-end Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 3, 31)
                    },
                    new JobPost
                    {
                        JobPostID = 4,
                        Title = "System Analyst",
                        StateCode = "BC",
                        City = "Delta",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 15)
                    },
                    new JobPost
                    {
                        JobPostID = 5,
                        Title = "UX Designer",
                        StateCode = "BC",
                        City = "Coquitlan",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 1, 25),
                        CloseDate = new DateTime(2018, 6, 30)
                    }
                );
                context.SaveChanges();
            }

        }

        // Populates the database with initial data
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            // receives the app context to check for data in the database
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.JobPosts.Any())
            {
                context.JobPosts.AddRange(
                    new JobPost
                    {
                        //Id = 1,
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "North Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 5, 30)
                    },
                    new JobPost
                    {
                        //Id = 2,
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 2)
                    },
                    new JobPost
                    {
                        //Id = 3,
                        Title = "Front-end Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 3, 31)
                    },
                    new JobPost
                    {
                        //Id = 4,
                        Title = "System Analyst",
                        StateCode = "BC",
                        City = "Delta",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 15)
                    },
                    new JobPost
                    {
                        //Id = 5,
                        Title = "UX Designer",
                        StateCode = "BC",
                        City = "Coquitlan",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 1, 25),
                        CloseDate = new DateTime(2018, 6, 30)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
