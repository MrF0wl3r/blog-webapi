using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_webapi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using blog_webapi.DAL;

namespace blog_webapi.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        public BlogController(BlogContext blogContext)
        {
            _dbContext = blogContext;
        }

        private readonly BlogContext _dbContext;

        // GET api/blog
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var data = _dbContext.Posts.Include(post => post.Comments).ToList();
            return data;
        }

        // GET api/blog/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return null;
        }

        // POST api/blog
        [HttpPost]
        public void Post([FromBody]Post value)
        {
        }

        // PUT api/blog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Post value)
        {
        }

        // DELETE api/blog/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
