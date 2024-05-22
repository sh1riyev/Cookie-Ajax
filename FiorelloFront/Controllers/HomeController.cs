using Microsoft.AspNetCore.Mvc;
using FiorelloFront.Services.Interface;
using FiorelloFront.ViewModels;

namespace FiorelloFront.Controllers;

public class HomeController : Controller
{
    private readonly IBlogService _blogService;
    private readonly IExpertService _expertService;
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    public HomeController(IBlogService blogService,
        IExpertService expertService,
        ICategoryService categoryService,
        IProductService productService)
    {
        _blogService = blogService;
        _expertService = expertService;
        _categoryService = categoryService;
        _productService = productService;
    }
    public async Task<IActionResult> Index()
    {

        HomeVM model = new()
        {
            Blogs = await _blogService.GetAllAsync(3),
            Experts = await _expertService.GetAllAsync(),
            Products=await _productService.GetAllAsync(),
            Categories=await _categoryService.GetAllASync()
        };
        return View(model);
    }
}

