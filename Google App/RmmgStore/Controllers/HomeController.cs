using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RmmgStore.Models;

namespace RmmgStore.Controllers;

public class HomeController : Controller
{

    public IActionResult Login()
    {
        return View();
    }
public IActionResult Validate(string email,string password)
{
    if(email=="rushabhgunjalrg17@gmail.com" && password=="Password")
    {
        return Redirect("/home/welcome");
    }


    return View();
   
}
public IActionResult Welcome()
{
    return View();
}

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
