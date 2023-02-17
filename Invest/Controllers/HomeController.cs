﻿using Invest.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}