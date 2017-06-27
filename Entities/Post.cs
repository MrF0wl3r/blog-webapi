using System;
using System.Collections.Generic;

namespace blog_webapi.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}