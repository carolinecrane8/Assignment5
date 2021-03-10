using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//this is the page where we have the info to remove 
namespace Assignment5.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repository;


        //Constructor
        public PurchaseModel (IBookstoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;

        }
        //properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            //what does this line do?
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Bookstore bookstore = repository.Bookstores.FirstOrDefault(p => p.BookId == bookId);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(bookstore, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove (long bookId, string returnUrl)
        {
           Cart.RemoveLine(Cart.Lines.First(cl => cl.Bookstore.BookId == bookId).Bookstore);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
