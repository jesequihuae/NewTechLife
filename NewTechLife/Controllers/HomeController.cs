using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewTechLife.Models;

namespace NewTechLife.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<PostHead> Posts = PostHead.getAllPosts(); 

            return View(Posts);
        }
    }
}