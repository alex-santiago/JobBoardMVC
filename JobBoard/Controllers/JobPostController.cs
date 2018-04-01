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
    public class JobPostController : Controller
    {
        private IJobPostRepository repository;

        public int PageSize = 4;

        public JobPostController(IJobPostRepository repo)
        {
            repository = repo;
        }

        // return an object with pagination and job posts in the page to the view
        public ViewResult List(int page = 1)
        {
            ViewBag.Title = "Search Results";

            return View(new JobPostsListViewModel
            {
                JobPosts = repository.JobPosts
                .OrderBy(p => p.PostDate)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.JobPosts.Count()
                },
                SearchOptions = new SearchOptions()
            });
        }

        //TODO: Add pagination to search results
        public ViewResult Search(string title, int page = 1)
        {
            ViewBag.Title = "Search Results";
            return View(nameof(List), new JobPostsListViewModel
            {
                JobPosts = repository.JobPosts
                .Where(p => title == null || p.Title.Contains(title))
                .OrderBy(p => p.PostDate)
                .Skip((page-1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = title == null ? 
                        repository.JobPosts.Count() :
                        repository.JobPosts.Where(el => el.Title.Contains(title)).Count()
                },
                SearchOptions = new SearchOptions
                {
                    Title = title
                }
            });
        }

        public ViewResult View(int jobPostID)
        {
            return View(nameof(View), repository.JobPosts
                .FirstOrDefault(p => p.JobPostID == jobPostID));
        }
    }
}
