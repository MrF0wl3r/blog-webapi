using Microsoft.EntityFrameworkCore;
using blog_webapi.Entities;

namespace blog_webapi.DAL
{
  public class BlogContext : DbContext
  {
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseInMemoryDatabase();
    }
  }
}