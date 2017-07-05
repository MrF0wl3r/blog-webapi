using Microsoft.EntityFrameworkCore;
using blog_webapi.Entities;
using System.Collections.Generic;

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
      var post = new Post();
      post.Id = 1;
      post.Title = "First Post";
      post.Contents = "Bacon ipsum dolor amet landjaeger venison beef, chicken filet mignon fatback porchetta frankfurter boudin. Sirloin shoulder rump venison ribeye meatloaf pork. Ground round ribeye chuck jowl doner, cupim boudin jerky tail. Picanha ham biltong shankle pastrami tenderloin jowl landjaeger venison tongue andouille porchetta strip steak chicken ground round. Pork belly boudin porchetta, turkey pork chop kielbasa fatback landjaeger ball tip jerky turducken. Meatball ham hock pork belly drumstick. Pork loin meatloaf rump, frankfurter chuck short ribs swine t-bone brisket.";
      post.Comments = new List<Comment>();
      post.Comments.Add(new Comment() { Id=1, Name="Bob", Message="Nice post!"});
      post.Comments.Add(new Comment() { Id=2, Name="Dylan", Message="Very meaty"});                
      Posts.Add(post);
      SaveChanges();
    }
  }
}