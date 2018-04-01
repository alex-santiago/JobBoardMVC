using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string name { get; set; }

        [ForeignKey("CompanyID")]
        public virtual ICollection<JobPost> jobPosts { get; set; }
    }
}
