using Microsoft.EntityFrameworkCore;
using blog_webapi.Entities;

namespace blog_webapi.DAL
{
  public class BlogContext : DbContext
  {
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      Posts.Add(new Post() { Id = 1, Title = "First Post", Contents = "lkasjdflkjal;jf aklsjdflkjas  laksjdflkjs"});
      SaveChanges();
    }
  }
}