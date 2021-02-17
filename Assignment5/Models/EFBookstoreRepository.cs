using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
