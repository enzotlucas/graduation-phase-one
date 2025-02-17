﻿using Microsoft.AspNetCore.Mvc;
using PoliceDepartment.EvidenceManager.MVC.Models;
using PoliceDepartment.EvidenceManager.SharedKernel.Extensions;
using System.Diagnostics;

namespace PoliceDepartment.EvidenceManager.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var officerType = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "OfficerType");

            ////TODO:
            ////Add the create officer page
            //if (officerType is not null && officerType.Value == Enum.GetName(OfficerType.Administrator))
            //    return RedirectToAction("Index", "Home");

            ////TODO:
            ////Add the cases page
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("error/{statusCode:length(3,3)}")]
        public IActionResult Errors(int statusCode)
        {
            var modelErro = new ErrorModel(statusCode);

            return View("Error", modelErro);
        }
    }
}