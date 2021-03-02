using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//this is the paging info page.  This is where we get the infor of how to number and group the items from the bd
//Man City is on the top of the table :,)
namespace Assignment5.Models
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
