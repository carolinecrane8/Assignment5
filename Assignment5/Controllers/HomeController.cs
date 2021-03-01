using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models.ViewModels;
//home controller. our favorite page where idk what the heck is happening 65% of the time. She is useful though. we can return the view of the repository here 
namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository _repository;
        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }


        public IActionResult Index(string category, int page = 1)
        {
            return View(new ProjectListViewModel
            {
                Bookstores = _repository.Bookstores
                 .Where(p => category == null || p.Category == category)
                 .OrderBy(p => p.BookId)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize)
                 ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems =category == null ? _repository.Bookstores.Count() :
                    _repository.Bookstores.Where(x => x.Category == category).Count()
                },
                CurrentCategory = category
            }) ;
    
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
