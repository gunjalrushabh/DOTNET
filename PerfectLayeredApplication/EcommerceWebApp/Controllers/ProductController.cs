using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerceWebApp.Models;

using BLL;
using BOL;

namespace EcommerceWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ProductManager pmanager = new ProductManager();
        List<Product> allProducts = ProductManager.GetAllProducts();
        this.ViewData["products"]=allProducts;
    

        return View();
    }


}
