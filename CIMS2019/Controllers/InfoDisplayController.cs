using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIMS2019.EF.Domain;
using CIMS2019.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIMS2019.Controllers
{
    public class InfoDisplayController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerExpectationService _customerExpectationService;
        public InfoDisplayController(ICustomerService customerService, ICustomerExpectationService customerExpectationService)
        {
            _customerService = customerService;
            _customerExpectationService = customerExpectationService;
        }
    public IActionResult Index()
        {
            List<CustomerExpectation> ceAll =  _customerExpectationService.GetCustomerExpectations().ToList();
            return View();
        }
    }
}