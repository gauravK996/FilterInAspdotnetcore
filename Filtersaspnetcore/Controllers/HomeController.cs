using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Filtersaspnetcore.Models;
using Filtersaspnetcore.NewFolder;

namespace Filtersaspnetcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? Id,String Name)
        {
            ViewBag.bname = Id;
            ViewBag.Id = Name;

            return View();
        }

        //[ServiceFilter(typeof(CustomFilter))]
        //[CustomFilter2]
        //[TypeFilter(typeof(CustomFilter))]
        [Custom3(10,"gauarav")]
        //[RequireHttps]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
