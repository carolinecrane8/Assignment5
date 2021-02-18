using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//so the concept of the repository is kinda confusing to me.  but basically we set a private variable to a public variable.  kinda loopy but it gets the job done.
namespace Assignment5.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDbContext _context;

        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Bookstore> Bookstores => _context.Bookstores;

    }
}
