using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTechLife.Models
{
    public class PostHead
    {
        public int idPostHead { get; set; }
        public String Title { get; set; }
        public String DescriptionPost { get; set; }
        public DateTime DatePosted { get; set; }

        public static List<PostHead> getAllPosts() {
            List<PostHead> Posts = new List<PostHead>();
            Posts.Add(new PostHead() {
                idPostHead = 1,
                Title = "Test Post",
                DescriptionPost = "",
                DatePosted = DateTime.Now
            });

            return Posts;
        }
    }
}