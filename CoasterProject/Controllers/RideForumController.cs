using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoasterProject.DAL;
using CoasterProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoasterProject.Controllers
{
    public class RideForumController : Controller
    {
        private IForumDAO forumDAO;
        public RideForumController(IForumDAO forumDAO)
        {
            this.forumDAO = forumDAO;
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(ForumPost model)
        {
            forumDAO.SavePost(model);

            return RedirectToAction("Index", new { Username = model.Username, Rating = model.Rating, PostDate = model.PostDate, ForumTitle = model.ForumTitle, ForumText = model.ForumText });
        }

        [HttpGet]
        public IActionResult Index(ForumPost model)
        {
            IList<ForumPost> posts = forumDAO.GetPosts();

            model.Results = posts;

            return View(model);
        }
    }
}