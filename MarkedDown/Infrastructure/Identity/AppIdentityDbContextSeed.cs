using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
  public class AppIdentityDbContextSeed
  {
    public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
    {
      if (!userManager.Users.Any())
      {
        var user = new AppUser
        {
          DisplayName = "Bob",
          Email = "bob@email.com",
          UserName = "bob@email.com",
          Address = new Address
          {
            FirstName = "Bob",
            LastName = "Bobbity",
            Street = "123 Place Lane",
            City = "Placeville",
            State = "WA",
            Zip = "98006"
          }
        };

        await userManager.CreateAsync(user, "Pa$$w0rd");
      }
    }
  }
}