using System.Threading.Tasks;
using RestSharp;

namespace MarkedDownClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/api");
      RestRequest request = new RestRequest($"products", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5001/api");
      RestRequest request = new RestRequest($"products/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetBrand(string brand)
    {
      RestClient client = new RestClient("http://localhost:5001/api");
      RestRequest request = new RestRequest($"products/{brand}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetType(string type)
    {
      RestClient client = new RestClient("http://localhost:5001/api");
      RestRequest request = new RestRequest($"products/{type}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}