﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
