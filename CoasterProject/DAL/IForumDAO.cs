using CoasterProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoasterProject.DAL
{
    public interface IForumDAO
    {
        /// <summary>
        /// Gets forum posts.
        /// </summary>
        /// <returns></returns>
        IList<ForumPost> GetPosts();

        /// <summary>
        /// Saves a post to the forum.
        /// </summary>
        /// <param name="newPost"></param>
        /// <returns></returns>
        int SavePost(ForumPost newPost);
    }
}
