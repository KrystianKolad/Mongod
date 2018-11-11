using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services.Interfaces;
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
