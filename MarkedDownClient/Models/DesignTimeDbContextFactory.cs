using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MarkedDownClient.Models
{
  public class MarkedDownClientContextFactory : IDesignTimeDbContextFactory<MarkedDownClientContext>
  {
    MarkedDownClientContext IDesignTimeDbContextFactory<MarkedDownClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<MarkedDownClientContext>();

      builder.UseSqlite(configuration["ConnectionStrings:DefaultConnection"]);

      return new MarkedDownClientContext(builder.Options);
    }
  }
}