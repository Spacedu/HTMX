using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Login");
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return Content("Page Register");
    }
}
