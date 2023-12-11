using examtask.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace examtask.MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
    }
}