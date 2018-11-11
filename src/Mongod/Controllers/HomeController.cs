using System;
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
                nameof(FlatController.Index),
                nameof(FlatController).Replace("Controller",String.Empty));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
