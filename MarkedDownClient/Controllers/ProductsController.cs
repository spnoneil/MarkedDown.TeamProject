using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarkedDownClient.Models;

namespace MarkedDownClient.Controllers
{
  public class ProductsController : Controller
  {
    public IActionResult Index()
    {
      // return View();
      List<Product> allProducts = Product.GetProducts();
      return View(allProducts);
    }






    // [HttpPost]
    // public IActionResult Index(Product product)
    // {
    //   Product.Post(product);
    //   return RedirectToAction("Index");
    // }

    // public IActionResult Details(int id)
    // {
    //   var product = Product.GetDetails(id);
    //   return View(product);
    // }

    // public IActionResult Edit(int id)
    // {
    //   var product = Product.GetDetails(id);
    //   return View(product);
    // }

    // [HttpPost]
    // public IActionResult Details(int id, Product product)
    // {
    //   product.ProductId = id;
    //   Product.Put(product);
    //   return RedirectToAction("Details", id);
    // }

    // public IActionResult Delete(int id)
    // {
    //   Product.Delete(id);
    //   return RedirectToAction("Index");
    // }
  }
}