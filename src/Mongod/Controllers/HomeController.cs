﻿using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mongod.Infrastructure.ViewModels;

namespace Mongod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(
                nameof(AdController.Index),
                nameof(AdController).Replace("Controller",String.Empty));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
