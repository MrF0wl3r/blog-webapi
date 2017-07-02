using blog_webapi.DAL;
using blog_webapi.Entities;

namespace blog_webapi
{
  static class Data
  {
    public static void Initialise(BlogContext context)
    {
      context.Posts.Add(new Post() { Id=1, Title="First Post", Contents="", Comments=null});
    }
  }
}