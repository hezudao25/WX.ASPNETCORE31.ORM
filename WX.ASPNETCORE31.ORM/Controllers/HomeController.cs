using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WX.ASPNETCORE31.DAL;
using WX.ASPNETCORE31.DAL.Excepression;
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
            //Users info = helper.Find<Users>(20432);
            Expression<Func<Users, bool>> expression = c => c.Id > 20431 && c.TrueName.Equals("何足道");
            Users info = helper.FindCondition<Users>(expression);
            this.ViewBag.Products = helper.Find<Products>(2032);
            this.ViewBag.User = info;
            // bool result = helper.Insert<Users>(helper.Find<Users>(41));
            info.TrueName = info.TrueName + "00100";
            info.LevelId = 2;
            //helper.Update<Users>(info);

            //helper.Delete<Users>(info);

          // Expression<Func<Users, bool>> expression = c => c.Id > 20431 && c.TrueName.Contains("何足道");
            //ExcepressionToSqlVisitor visitor = new ExcepressionToSqlVisitor();
            //{
            //    Expression<Func<Users, bool>> expression = c => c.TrueName.Equals("何足道");
            //    visitor.Visit(expression);
            //    string where = visitor.GetWhere();
            //}

            //helper.DeleteCondition<Users>(expression);
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
