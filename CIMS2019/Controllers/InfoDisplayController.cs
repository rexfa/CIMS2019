,using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIMS2019.Controllers
{
    public class InfoDisplayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}