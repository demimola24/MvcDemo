﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcAssg.Models;

namespace MvcAssg.Controllers;

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

     // GET: /Home/Into/ 
    public IActionResult Intro()
    {
        ViewData["Title"] = "Introduction Page";
        ViewData["Section"] = "Intro Section  paragraph of text ";
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
