using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RhodesShoppe.Models;

namespace RhodesShoppe.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
