using Microsoft.EntityFrameworkCore;
using blog_webapi.Entities;

namespace blog_webapi.DAL
{
  public class BlogContext : DbContext
  {
    public DbSet<Post> Posts { get; set; }

    public BlogContext(DbContextOptions<BlogContext> options)
      : base(options)
    {
    }

    public void Seed()
    {
      Posts.Add(new Post() { Id=1, Title="First Post", Contents="", Comments=null});
      SaveChanges();
    }
  }
}