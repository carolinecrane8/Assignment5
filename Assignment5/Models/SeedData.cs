using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//this is the seed data file where I set all of the information for my database. it is part of the model first idea of program building
namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();
            
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        
            if(!context.Bookstores.Any())
            {
                context.Bookstores.AddRange(
                    new Bookstore
                    {
                       // BookId = 1,
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = " Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Classic",
                        Classification = "Fiction",
                        Price = 9.95,
                        PageNum = 1488
                    },

                    new Bookstore
                    {
                        //BookId = 2,
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = " Kearns ",
                        AuthorLast = " Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        Price = 14.58,
                        PageNum = 944
                    },

                    new Bookstore
                    {
                       // BookId = 3,
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = " Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        Price = 21.54,
                        PageNum = 832
                    },

                    new Bookstore
                    {
                        //BookId = 4,
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = " C. ",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        Price = 11.61,
                        PageNum = 864
                    },

                    new Bookstore
                    {
                        //BookId = 5,
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = " Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Historical",
                        Classification = "Non-Fiction",
                        Price = 13.33,
                        PageNum = 528
                    },

                    new Bookstore
                    {
                        //BookId = 6,
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = " Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Historical Fiction",
                        Classification = "Fiction",
                        Price = 15.95,
                        PageNum = 288
                    },

                    new Bookstore
                    {
                        //BookId = 7,
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = " Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Self-Help",
                        Classification = "Non-Fiction",
                        Price = 14.99,
                        PageNum = 304
                    },

                    new Bookstore
                    {
                        //BookId = 8,
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = " Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Self-Help",
                        Classification = "Non -Fiction",
                        Price = 21.66,
                        PageNum = 240
                    },

                    new Bookstore
                    {
                        //BookId = 9,
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = " Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Business",
                        Classification = "Non-Fiction",
                        Price = 29.16,
                        PageNum = 400

                    },


                    new Bookstore
                    {
                        //BookId = 10,
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = " Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Thrillers",
                        Classification = "Fiction",
                        Price = 15.03,
                        PageNum = 642
                    },

                     new Bookstore
                     {
                         //BookId = 11,
                         Title = "Little Women",
                         AuthorFirst = "Lousia ",
                         AuthorMiddle = "May",
                         AuthorLast = " Alcott",
                         Publisher = "Roberts Brothers",
                         ISBN = "978-1503280298",
                         Category = "Comedy",
                         Classification = "Fiction",
                         Price = 11.83,
                         PageNum = 759
                     },
                      new Bookstore
                      {
                          //BookId = 12,
                          Title = "Princess Academy",
                          AuthorFirst = "Shannon",
                          AuthorMiddle = "",
                          AuthorLast = " Hale",
                          Publisher = "Bloomsbury Press",
                          ISBN = "978-1599900735",
                          Category = "Fantasy",
                          Classification = "Fiction",
                          Price = 8.99,
                          PageNum = 314
                      },
                       new Bookstore
                       {
                           //BookId = 13,
                           Title = "The Help",
                           AuthorFirst = "Kathryn",
                           AuthorMiddle = "",
                           AuthorLast = " Stockett",
                           Publisher = "Penguin Books",
                           ISBN = "978-0425232200",
                           Category = "Historical",
                           Classification = "Fiction",
                           Price = 11.99,
                           PageNum = 524
                       }


                   ) ;
                context.SaveChanges();
            }
        }
    }
}
