using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//in this model we create the cart.
namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Bookstore bookstore, int quantity)
        {
            CartLine line = Lines.Where(p => p.Bookstore.BookId == bookstore.BookId).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Bookstore = bookstore,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Bookstore bookstore) =>
            Lines.RemoveAll(x => x.Bookstore.BookId == bookstore.BookId);

        public double ComputeTotalSum() => Lines.Sum(e => e.Bookstore.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Bookstore Bookstore { get; set; }
            public int Quantity { get; set; }
        }
    }

