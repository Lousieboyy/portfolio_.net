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
        var myProjects = new List<Project>();
        var mySkills = new List<Skill>();
        var myTools = new List<Tool>();

        var model = new HomeViewModel
        {
            Projects = myProjects,
            Skills = mySkills,
            Tools = myTools
        };
         mySkills.Add(new Skill
         {
             Id = 1,
             Name = "C++",
             ImageUrl = "/images/c++.png",
             StarRating = 3.ToString()
         });
        mySkills.Add(new Skill
        {
            Id = 2,
            Name = "HTML",
            ImageUrl = "/images/HTML.png",
            StarRating = 5.ToString()
        });
        mySkills.Add(new Skill
        {
            Id = 3,
            Name = "JavaScript",
            ImageUrl = "/images/JavaScript.png",
            StarRating = 3.ToString()
        });
        mySkills.Add(new Skill
        {
            Id = 4,
            Name = "PHP",
            ImageUrl = "/images/PHP.png",
            StarRating = 3.ToString()
        });
        mySkills.Add(new Skill
        {
            Id = 5,
            Name = "C#",
            ImageUrl = "/images/csharp.png",
            StarRating = 3.ToString()
        });
        mySkills.Add(new Skill
        {
            Id = 6,
            Name = "Java",
            ImageUrl = "/images/Java.png",
            StarRating = 3.ToString()
        });
        mySkills.Add(new Skill
        {
            Id = 7,
            Name = "Kotlin",
            ImageUrl = "/images/kotlin.svg",
            StarRating = 3.ToString()
        });
        myTools.Add(new Tool
        {
            Id = 1,
            Name = "Visual Studio",
            ImageUrl = "/images/visualstudio.png"
        });
        myTools.Add(new Tool
        {
            Id = 2,
            Name = "GitHub",
            ImageUrl = "/images/github.png"
        });
        myTools.Add(new Tool
        {
            Id = 3,
            Name = "Postman",
            ImageUrl = "/images/postman.png"
        });
        myTools.Add(new Tool 
        {
            Id = 4,
            Name = "Figma",
            ImageUrl = "/images/figma.svg"
        });
        myTools.Add(new Tool
        {
            Id = 5,
            Name = "Android Studio",
            ImageUrl = "/images/androidstudio.svg"
        });
    
        return View(model);
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
