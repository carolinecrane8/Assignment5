using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//this is the project list view model. it connects the database items to the paging info.
namespace Assignment5.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Bookstore> Bookstores { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
