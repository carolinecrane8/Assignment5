using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//this is the bookstore model where I set the field requirements. it also is where i set up the get/set of pulling data.
namespace Assignment5.Models
{
    public class Bookstore
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string? AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}$", ErrorMessage = "Invalid form for ISBN")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Classification { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
