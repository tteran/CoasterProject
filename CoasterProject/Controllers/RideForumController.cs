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
        public IActionResult New(ForumPost model)
        {
            if(!ModelState.IsValid)
            {
                forumDAO.SavePost(model);
                return RedirectToAction("Index", new { Username = model.Username, Rating = model.Rating, ForumTitle = model.ForumTitle, ForumText = model.ForumText });
            }

            return View(model);
            
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