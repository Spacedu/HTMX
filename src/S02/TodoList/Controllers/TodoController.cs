using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers;

public class TodoController : Controller
{
    public IActionResult Index()
    {
        return Content("Todo App");
    }
}
