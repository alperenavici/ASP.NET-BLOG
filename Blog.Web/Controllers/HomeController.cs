using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.Web.Models;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;

namespace Blog.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IArticleService articleService;

    public HomeController(ILogger<HomeController> logger,IArticleService articleService)
    {
        _logger = logger;
        this.articleService = articleService;
    }

    public async Task<IActionResult> Index()
    {   
        var articles=await articleService.GetAllArticlesAsync();
        return View(articles);
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