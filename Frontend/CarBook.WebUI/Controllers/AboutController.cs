﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımızda";
            ViewBag.v1 = "Vizyonumuz & Misyonumuz";
            return View();
        }
    }
}
