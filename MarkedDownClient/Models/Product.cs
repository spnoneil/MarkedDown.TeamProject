
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;

namespace MarkedDownClient.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public string PictureUrl { get; set; }
    public ProductType ProductType { get; set; }
    // public int ProductTypeId { get; set; }
    public ProductBrand ProductBrand { get; set; }
    // public int ProductBrandId { get; set; }
    
    public static List<Product> GetProducts()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(result["data"].ToString());

      return productList;
    }

    // public static Product GetDetails(int id)
    // {
    //   var apiCallTask = ApiHelper.Get(id);
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   Product product = JsonConvert.DeserializeObject<Product>(jsonResponse.ToString());

    //   return product;
    // }

    // public static Product GetBrand(string brand)
    // {
    //   var apiCallTask = ApiHelper.GetBrand(brand);
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   Product product = JsonConvert.DeserializeObject<Product>(jsonResponse.ToString());

    //   return product;
    // }

    // public static Product GetType(string type)
    // {
    //   var apiCallTask = ApiHelper.GetType(type);
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   Product product = JsonConvert.DeserializeObject<Product>(jsonResponse.ToString());

    //   return product;
    // }

    // public static void Post(Product product)
    // {
    //   string jsonProduct = JsonConvert.SerializeObject(product);
    //   var apiCallTask = ApiHelper.Post(jsonProduct);
    // }

    // public static void Put(Product product)
    // {
    //   string jsonProduct = JsonConvert.SerializeObject(product);
    //   var apiCallTask = ApiHelper.Put(product.ProductId, jsonProduct);
    // }

    // public static void Delete(int id)
    // {
    //   var apiCallTask = ApiHelper.Delete(id);
    // }      
  }
}


