using System.Diagnostics;
using Day01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 0)
                return View("View1");
            else
                return Content("Hello World!");
        }

        //public ContentResult Content(string Content)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = Content;
        //    return result;
        //}

        //public ViewResult View(string View)
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = View;
        //    return result;
        //}

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
