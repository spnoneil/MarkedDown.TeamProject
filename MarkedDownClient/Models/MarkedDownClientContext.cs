using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarkedDownClient.Models
{
  public class MarkedDownClientContext : IdentityDbContext<ApplicationUser>
  {
    //public DbSet<{Name}> {Name} {get; set;}
    public MarkedDownClientContext(DbContextOptions options) : base(options) { }

  }
}