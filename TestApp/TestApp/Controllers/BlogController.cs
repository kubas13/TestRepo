
using aspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
