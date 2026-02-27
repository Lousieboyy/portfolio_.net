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

    public static string embeddedUrl(String url)
    {
        if (url.Contains("youtu.be/"))
        {
            var videoId = url.Split("youtu.be/")[1].Split('?')[0];
            return $"https://www.youtube.com/embed/{videoId}";
        }
        if (url.Contains("youtube.com/watch/"))
        {
            var uri = new Uri(url);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            var videoId = query["v"];
            return $"https://www.youtube.com/embed/{videoId}";
        }
        if (url.Contains("youtube.com/shorts/"))
        {
           var videoId = url.Split("youtube.com/shorts/")[1].Split('?')[0];
            return $"https://www.youtube.com/embed/{videoId}";
        }
        return url;
    }

    public IActionResult Certificate()
    {
        var myCertificate = new List<Certificate>();
    
        myCertificate.Add(new Certificate
        {
            Id = 1,
            Name = "Implementing Cloud Load Balancing for Compute Engine",
            ImageUrl = "/images/cert1.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12794002",
            Date = new DateTime(2024, 11, 12)
        });
        myCertificate.Add(new Certificate
        {
            Id = 2,
            Name = "Build a Secure Google Cloud Network",
            ImageUrl = "/images/cert2.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12793158",
            Date = new DateTime(2024, 11, 12)
        });
        myCertificate.Add(new Certificate
        {
            Id = 3,
            Name = "Prepare Data for ML APIs on Google Cloud",
            ImageUrl = "/images/cert3.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12790204",
            Date = new DateTime(2024, 11, 12)
        });
        myCertificate.Add(new Certificate
        {
            Id = 4,
            Name = "Set Up an App Dev Environment on Google Cloud",
            ImageUrl = "/images/cert4.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12771239",
            Date = new DateTime(2024, 11, 11)
        });
        myCertificate.Add(new Certificate
        {
            Id = 5,
            Name = "Google Cloud Computing Foundations: Data, ML, and AI in Google Cloud",
            ImageUrl = "/images/cert5.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12757318",
            Date = new DateTime(2024, 11, 10)
        }); 
        myCertificate.Add(new Certificate
        {
            Id = 6,
            Name = "Google Cloud Computing Foundations: Networking & Security in Google Cloud",
            ImageUrl = "/images/cert6.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12734081",
            Date = new DateTime(2024, 11, 9)
        });
        myCertificate.Add(new Certificate
        {
            Id = 7,
            Name = "Google Cloud Computing Foundations: Infrastructure in Google Cloud",
            ImageUrl = "/images/cert7.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12720384",
            Date = new DateTime(2024, 11, 9)
        });
        myCertificate.Add(new Certificate
        {
            Id = 8,
            Name = "Google Cloud Computing Foundations: Cloud Computing Fundamentals",
            ImageUrl = "/images/cert8.png",
            Link = "https://www.skills.google/public_profiles/fadc3a9b-b62a-4d6a-8547-b24dc966646c/badges/12660927",
            Date = new DateTime(2024, 11, 6)
        }); 
        var sortedCertificates = myCertificate.OrderByDescending(c => c.Date).ToList();
        var model = new CertificateViewModel
        {
            Certificate = sortedCertificates
        };
        return View(model);
    }

    public IActionResult Index()
    {
        string targetUrl = "https://github.com";
        string fetchedTitle = LinkPreview.getLinkPreview(targetUrl);

        ViewBag.LinkPreviewTitle = fetchedTitle;
        ViewBag.MyPreviewUrl = targetUrl;

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
        mySkills.Add(new Skill
        {
            Id = 8,
            Name = "Python",
            ImageUrl = "/images/python.png",
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
        myProjects.Add(new Project
        {
            Id = 1,
            Name = "Final Project DITM 2113 MULTIMEDIA SYSTEM",
            Description = "",
            ImageUrl = "",  
            ProjectUrl = "https://youtu.be/HEqx5QQTABs?si=222anSoUAx4M71JQ"
        });
        myProjects.Add(new Project
        {
            Id = 2,
            Name = "Maternal Pregnancy Tracker",
            Description = "In Maintenance",
            ImageUrl = "",  
            ProjectUrl = ""
        });
        myProjects.Add(new Project
        {
            Id = 3,
            Name = "Campus Tutor - Peer to Peer Tutoring System",
            Description = "",
            ImageUrl = "/images/campustutor.png",
            ProjectUrl = "https://github.com/NAD3012/CampusTutor.git"
        });
        myProjects.Add(new Project
        {
            Id = 4,
            Name = "Saving Goal Gamification App",
            Description = "",
            ImageUrl = "",
            ProjectUrl = "https://youtube.com/shorts/6mKU7RNpdh8?si=QWWhoi1f84CIJC5h"
        });
        myProjects.Add(new Project
        {
            Id = 5,
            Name = "Smart-City-Citizen-App",
            Description = "Coming Soon",
            ImageUrl = "",
            ProjectUrl = ""
        });
        myProjects.Add(new Project
        {
            Id = 6,
            Name = "Mosque-Assist-App",
            Description = "Coming Soon",
            ImageUrl = "",
            ProjectUrl = ""
        });
        myProjects.Add(new Project
        {
            Id = 7,
            Name = "Game-Platform",
            Description = "Coming Soon",
            ImageUrl = "",
            ProjectUrl = ""
        });
        return View(model);
    }
    public IActionResult Curricular()
    {
        var myCurricular = new List<Curricular>();
        myCurricular.Add(new Curricular
        {
            Id = 1,
            Name = "Service Learning Malaysia (SULAM)",
            ImageUrl = "/images/studentcouncil.png",
            Date = new DateTime(2023, 6, 1)
        });
        myCurricular.Add(new Curricular
        {
            Id = 2,
            Name = "Ficts Buddies",
            ImageUrl = "/images/fictsbuddies.png",
            Date = new DateTime(2023, 6, 1)
        });
        myCurricular.Add(new Curricular
        {
            Id = 3,
            Name = "Sukan Antara Fakulti (SAF) Crew",
            ImageUrl = "/images/safcrew.png",
            Date = new DateTime(2023, 6, 1)
        });
        var model = new CurricularViewModel
        {
            Curricular = myCurricular
        };
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
