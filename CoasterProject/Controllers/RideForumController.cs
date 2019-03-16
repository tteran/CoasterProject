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
        [ValidateAntiForgeryToken]
        public IActionResult New(ForumPost forumPost)
        {
            bool wasSaved = forumDAO.SavePost(forumPost);

            if (wasSaved)
            {
                TempData["SavedPost"] = "Thank you for the feedback!";
            }

            return RedirectToAction("Index");/*, new { Username = forumPost.Username, Rating = forumPost.Rating, ForumTitle = forumPost.ForumTitle, ForumText = forumPost.ForumText });*/
        }

        [HttpGet]
        public IActionResult Index(ForumPost model)
        {
            IList<ForumPost> forumPosts = forumDAO.GetPosts();
            model.PostResults = forumPosts;
            return View(forumPosts);
        }
    }
}