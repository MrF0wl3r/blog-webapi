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
      post.Contents = "Bacon ipsum dolor amet pork turkey boudin, burgdoggen drumstick kevin porchetta sirloin meatball rump pork loin leberkas venison cow pancetta.\n\n" +
                      "  \n\n" + 
                      "Biltong landjaeger alcatra cupim, turkey brisket ball tip chuck short loin frankfurter. Short loin corned beef meatloaf, ribeye sirloin tenderloin ground round flank chuck shoulder beef fatback jerky. Pork chop venison strip steak, porchetta meatball pancetta bacon landjaeger. Ribeye pork chop frankfurter biltong. Beef short loin picanha, sausage strip steak biltong flank rump doner prosciutto brisket ribeye venison pork. Strip steak turkey pastrami beef pork. Bacon ground round shank landjaeger salami corned beef swine shankle beef ribs porchetta. Shoulder flank beef ribs doner jerky filet mignon sirloin rump fatback sausage boudin. Chuck prosciutto corned beef jowl, t-bone ham turducken drumstick pork belly salami cow. Frankfurter picanha tail shankle beef flank.";
      post.Comments = new List<Comment>();
      post.Comments.Add(new Comment() { Id=1, Name="Bob", Message="Nice post!"});
      post.Comments.Add(new Comment() { Id=2, Name="Dylan", Message="Very meaty"});                
      Posts.Add(post);
      SaveChanges();
    }
  }
}