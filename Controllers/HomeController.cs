using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var myProjects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Name = "Project One",
                Description = "Description for project one.",
                ImageUrl = "/images/project1.png",
                ProjectUrl = "https://example.com/project1"
                }
            };
        return View(myProjects);
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
