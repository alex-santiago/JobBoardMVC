﻿using JobBoard.Models;
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

        // Populates the database with initial data
        public static void InitializeDB(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.JobPosts.Any())
            {
                context.Companies.AddRange(
                    new Company
                    {
                        name = "LongBoards Inc."
                    },
                    new Company
                    {
                        name = "Dev Inc."
                    }
                );
                context.SaveChanges();

                context.JobPosts.AddRange(
                    new JobPost
                    {
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "North Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 5, 30),
                        CompanyID = context.Companies.Single( c => c.name == "LongBoards Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "Full Stack Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 2),
                        CompanyID = context.Companies.Single( c => c.name == "Dev Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "Front-end Developer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 12),
                        CloseDate = new DateTime(2018, 3, 31),
                        CompanyID = context.Companies.Single( c => c.name == "Dev Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "System Analyst",
                        StateCode = "BC",
                        City = "Delta",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 2, 15),
                        CompanyID = context.Companies.Single( c => c.name == "LongBoards Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "UX Designer",
                        StateCode = "BC",
                        City = "Coquitlam",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 1, 25),
                        CloseDate = new DateTime(2018, 6, 30),
                        CompanyID = context.Companies.Single( c => c.name == "LongBoards Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "UX Designer",
                        StateCode = "BC",
                        City = "Delta",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 1, 25),
                        CloseDate = new DateTime(2018, 3, 31),
                        CompanyID = context.Companies.Single( c => c.name == "LongBoards Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "Programer",
                        StateCode = "BC",
                        City = "Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 1, 25),
                        CloseDate = new DateTime(2018, 1, 31),
                        CompanyID = context.Companies.Single( c => c.name == "Dev Inc.").ID
                    },
                    new JobPost
                    {
                        Title = "Xamarin Developer",
                        StateCode = "BC",
                        City = "North Vancouver",
                        CountryCode = "Canada",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec commodo porttitor elit nec porttitor. Mauris auctor risus quis commodo volutpat. Quisque feugiat blandit velit in interdum. Cras sed faucibus orci. Maecenas mi orci, pretium non magna eu, fringilla porttitor mauris. Cras rutrum pulvinar lorem, sit amet malesuada nulla ornare ut",
                        PostDate = new DateTime(2018, 3, 28),
                        CompanyID = context.Companies.Single( c => c.name == "LongBoards Inc.").ID
                    }
                );
                context.SaveChanges();
            }

        }
    }
}
