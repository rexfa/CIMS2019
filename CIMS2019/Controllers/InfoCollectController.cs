using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIMS2019.Controllers
{
    public class InfoCollectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(string str)
        {
            return Redirect("http://u.vivatech.cn/h/6601");
        }
    }
}