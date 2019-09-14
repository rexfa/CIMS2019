using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIMS2019.EF.Domain;
using CIMS2019.Models;
using CIMS2019.Services;
using System.Diagnostics;

namespace CIMS2019.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerExpectationService _customerExpectationService;
        public HomeController(ICustomerService customerService, ICustomerExpectationService customerExpectationService)
        {
            _customerService = customerService;
            _customerExpectationService = customerExpectationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestDatabase()
        {
            var c = _customerService.GetCustomerByIDNumber("1223");
            return new JsonResult(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
