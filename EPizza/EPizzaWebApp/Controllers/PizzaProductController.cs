using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EPizzaWebApp.Models;
using BLL;
using System.Collections.Generic;
using BOL;

namespace EPizzaWebApp.Controllers;

public class PizzaProductController : Controller
{
    private readonly ILogger<PizzaProductController> _logger;

    public PizzaProductController(ILogger<PizzaProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager=new CatalogManager();
        List<PizzaProduct> allProducts=manager.GetAllProducts();
      //  return View(allProducts);
      this.ViewData["product"]=allProducts;
      return View();
        
    }
    public IActionResult Details(int id)
    {
        CatalogManager manager=new CatalogManager();
        PizzaProduct product=manager.GetProduct(id);
        this.ViewData["product"]=product;
        return View();
    }

}