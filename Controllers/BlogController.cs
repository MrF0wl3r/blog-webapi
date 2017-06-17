using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_webapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blog_webapi.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        // GET api/blog
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            var blog = new Blog() { Id = 1, Title = "First Post", Contents = "lkasjdflkjal;jf aklsjdflkjas  laksjdflkjs"};
            return new [] { blog };
        }

        // GET api/blog/5
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return null;
        }

        // POST api/blog
        [HttpPost]
        public void Post([FromBody]Blog value)
        {
        }

        // PUT api/blog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Blog value)
        {
        }

        // DELETE api/blog/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
