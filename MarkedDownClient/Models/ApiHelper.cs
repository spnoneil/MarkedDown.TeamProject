using System.Threading.Tasks;
using RestSharp;
using System;

namespace MarkedDownClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/api");
      RestRequest request = new RestRequest($"Products", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      
      return response.Content;
    }
    // public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("https://localhost:5001/api");
    //   RestRequest request = new RestRequest($"Products/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task<string> Search(string name)
    // {
    //   RestClient client = new RestClient("https://localhost:5001/api");
    //   RestRequest request = new RestRequest($"Products?Search={name}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task<string> GetBrand(string brand)
    // {
    //   RestClient client = new RestClient("https://localhost:5001/api");
    //   RestRequest request = new RestRequest($"Products/{brand}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task<string> GetType(string type)
    // {
    //   RestClient client = new RestClient("https://localhost:5001/api");
    //   RestRequest request = new RestRequest($"Products/{type}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task Post(string newProduct)
    // {
    //   RestClient client = new RestClient("http://localhost:5001/api");
    //   RestRequest request = new RestRequest($"products", Method.POST);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newProduct);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Put(int id, string newProduct)
    // {
    //   RestClient client = new RestClient("http://localhost:5001/api");
    //   RestRequest request = new RestRequest($"products/{id}", Method.PUT);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newProduct);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Delete(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"products/{id}", Method.DELETE);
    //   request.AddHeader("Content-Type", "application/json");
    //   var response = await client.ExecuteTaskAsync(request);
    // }
  }
}