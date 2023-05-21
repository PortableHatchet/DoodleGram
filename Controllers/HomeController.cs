using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoodleGram.Models;

namespace DoodleGram.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//Main homepage view
    public IActionResult Index()
    {
        return View();
    }
//Privacy View
    public IActionResult Privacy()
    {
        return View();
    }
    //Pulls up user profile
    public IActionResult Profile()
    {
        return View();
    }
    
    public IActionResult SignUpButton()
    {
        return View("~/Views/Account/SignUp.cshtml");
    }

    public IActionResult LoginButton()
    {
        return View("~/Views/Account/Login.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
