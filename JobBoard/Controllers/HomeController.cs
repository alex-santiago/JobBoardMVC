using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Board jobboard = new Board();
            jobboard.JobPosts.Add(new JobPost { Id = 1, Title = "Sample 1", PostDate = DateTime.Now, AddressLine1 = "101-270 3RD ST W", City = "North Vancouver", PostalCode = "V7M 1G1" });
            jobboard.JobPosts.Add(new JobPost { Id = 2, Title = "Sample 2", PostDate = DateTime.Now, AddressLine1 = "3696 Carnarvon AVE", City = "North Vancouver", PostalCode = "V7N 1H7" });

            return View(jobboard);
        }
    }
}
