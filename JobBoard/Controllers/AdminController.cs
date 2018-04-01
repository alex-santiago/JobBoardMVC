using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoard.Models;
using JobBoard.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class AdminController : Controller
    {
        private IJobPostRepository repository;

        public int PageSize = 10;

        public AdminController(IJobPostRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(new JobPostsListViewModel
            {
                JobPosts = repository.JobPosts
                .OrderBy(p => p.PostDate)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = 1,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.JobPosts.Count()
                },
                SearchOptions = new SearchOptions()
            });

        public ViewResult Edit(int jobPostID) => View(repository.JobPosts
            .FirstOrDefault(jp => jp.JobPostID == jobPostID));

        [HttpPost]
        public IActionResult Edit(JobPost jobPost)
        {
            if (ModelState.IsValid)
            {
                repository.SaveJobPost(jobPost);
                TempData["message"] = $"The job post for {jobPost.Title} has been saved.";
                return RedirectToAction(nameof(Index));
                //return View(jobPost);
            }
            else
            {
                return View(jobPost);
            }
        }

        public IActionResult Create() => View("Edit", new JobPost() { CompanyID = 1, PostDate = DateTime.Now });

        [HttpPost]
        public IActionResult Delete(int jobPostID)
        {
            JobPost deletedJobPost =  repository.DeleteJobPost(jobPostID);
            if (deletedJobPost != null)
            {
                TempData["message"] = $"The job post for {deletedJobPost.Title} has been deleted.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
