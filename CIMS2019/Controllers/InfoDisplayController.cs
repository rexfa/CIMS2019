using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIMS2019.EF.Domain;
using CIMS2019.Models;
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
            return View();
        }
        public  IActionResult CEList()
        {
            List<CustomerExpectation> ceAll = _customerExpectationService.GetCustomerExpectations().ToList();
            IEnumerable<CustomerExpectationDisplayModel> models = ceAll.Select(x => { return CustomerExpectationDisplayModel.GenerateModelForList(x); });
            return View(models);
        }
        public IActionResult Details(int id)
        {
            CustomerExpectation customerExpectation = _customerExpectationService.GetCustomerExpectationById(id);

            return View();
        }
    }
}