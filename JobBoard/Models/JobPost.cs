using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace JobBoard.Models
{
    // Class that represents a Job Post and its properties
    public class JobPost
    {
        public JobPost()
        {
        }

        public int JobPostID { get; set; }
        [Required(ErrorMessage = "Please enter a Title for the Job Post")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the Job Post Description")]
        public string Description { get; set; }
        public string CountryCode { get; set; } // TODO: Review; 
        public string StateCode { get; set; }
        [Required(ErrorMessage = "Please enter the Job Post Location")]
        public string City { get; set; } // TODO: Review; 
        public string PostalCode { get; set; } // TODO: Review; 
        [Required(ErrorMessage = "Please enter the Job Post Date")]
        public DateTime PostDate { get; set; }
        public DateTime? CloseDate { get; set; }

        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

    }
}
