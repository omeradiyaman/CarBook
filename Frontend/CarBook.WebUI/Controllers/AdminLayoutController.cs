﻿using CarBook.WebUI.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AdminLayoutController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminSidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminFooterPartial() 
        {
            return PartialView();
        }
    }
}
