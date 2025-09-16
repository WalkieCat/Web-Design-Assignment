using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcWebSite.Models;

namespace AspNetCoreMvcWebSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var assignmentOneMark = 27;
        var assignmentTwoMark = 27;
        var tutorialMark = 36;
        var totalMark = assignmentOneMark + assignmentTwoMark + tutorialMark;
        ViewBag.MyTotalMark = totalMark;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
