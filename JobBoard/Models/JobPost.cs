using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobBoard.Models
{
    // Class that represents a Job Post and its properties
    public class JobPost
    {
        public JobPost()
        {
        }

        public int JobPostID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CountryCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string StateCode { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime? CloseDate { get; set; }

        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

    }
}
