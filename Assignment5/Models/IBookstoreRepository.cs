using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//ALLOWS US TO QUERY IN THE DATABASE!!!! (not yet) BUT THIS IS AWESOMEEEEE
namespace Assignment5.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Bookstore> Bookstores { get; }
    }
}
