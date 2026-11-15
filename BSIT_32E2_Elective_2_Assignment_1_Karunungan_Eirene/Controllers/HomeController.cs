using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT_32E2_Elective_2_Assignment_1_Karunungan_Eirene.Models;

namespace BSIT_32E2_Elective_2_Assignment_1_Karunungan_Eirene.Controllers;

public class HomeController : Controller
{
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
