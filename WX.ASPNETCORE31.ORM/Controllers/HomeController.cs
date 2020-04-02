using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WX.ASPNETCORE31.DAL;
using WX.ASPNETCORE31.Model;
using WX.ASPNETCORE31.ORM.Models;

namespace WX.ASPNETCORE31.ORM.Controllers
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
            SqlHelper helper = new SqlHelper();
            this.ViewBag.User = helper.Find<Users>(41);
            this.ViewBag.Products = helper.Find<Products>(2032);

            bool result = helper.Insert<Users>(helper.Find<Users>(41));
            return View();
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
