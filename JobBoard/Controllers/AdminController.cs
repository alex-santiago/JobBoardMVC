using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class AdminController : Controller
    {
        private IJobPostRepository repository;

        public AdminController(IJobPostRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index() => View(repository.JobPosts);

        public ViewResult Edit(int jobPostID) => View(repository.JobPosts
            .FirstOrDefault(jp => jp.JobPostID == jobPostID));

        [HttpPost]
        public IActionResult Edit(JobPost jobPost)
        {
            if (ModelState.IsValid)
            {
                repository.SaveJobPost(jobPost);
                TempData["message"] = $"The job post for {jobPost.Title} has been saved.";
                //return RedirectToAction("Edit","Admin", jobPost.JobPostID);
                return View(jobPost);
            }
            else
            {
                return View(jobPost);
            }
        }
    }
}
