using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using BOL;
using BLL;


namespace TestApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> allProduct=CatalogManager.GetallProducts();

        ViewBag.products=allProduct;
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        Product prod=new Product();
        return View(prod);
    }
    [HttpPost]
    public IActionResult Insert(Product createProduct)
    {
        CatalogManager.InsertProduct(createProduct);
        return RedirectToAction("Index");
    }
}