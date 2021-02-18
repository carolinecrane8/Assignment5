using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//this page. is very important.  we set the context of the database here. create classes for it.  and eventually call this in other stuff.
namespace Assignment5.Models
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext (DbContextOptions<BookstoreDbContext> options): base (options)
        {

        }

        public DbSet<Bookstore> Bookstores { get; set; }
    }
}
