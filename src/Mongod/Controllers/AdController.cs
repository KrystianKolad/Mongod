using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services.Interfaces;

namespace Mongod.Controllers
{
    public class AdController : Controller
    {
        private readonly IService<AdModel, Ad> _service;
        public AdController(IService<AdModel,Ad> service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AdModel()
            {
                Address = new AddressModel(),
                Owner = new UserModel()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AdModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            await _service.AddAsync(model);
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }
    }
}