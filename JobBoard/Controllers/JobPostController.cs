using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class JobPostController : Controller
    {
        private IJobPostRepository repository;

        public JobPostController(IJobPostRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.JobPosts);

     }
}
