using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nhom2.Ecom.Web.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}