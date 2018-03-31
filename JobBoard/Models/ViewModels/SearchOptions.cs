using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models.ViewModels
{
    public class SearchOptions
    {
        public string Title { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string City { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}
