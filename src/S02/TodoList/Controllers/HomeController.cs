using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return Content("Page Login");
    }

    public IActionResult Register()
    {
        return Content("Page Register");
    }
}
