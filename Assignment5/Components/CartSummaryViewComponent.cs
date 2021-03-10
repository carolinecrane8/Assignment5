﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;
//this class is used to connect all of the cart stuffs
namespace Assignment5.Components
{
    public class CartSummaryViewComponent: ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            //fix this
            return View(cart);
        }
    }
}
