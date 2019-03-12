using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoasterProject.Models
{
    /// <summary>
    /// Model for forum post.
    /// </summary>
    public class ForumPost
    {
        public int Id { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Rating")]
        public int Rating { get; set; }

        public DateTime PostDate { get; set; }

        [Display(Name = "Subject")]
        public string ForumTitle { get; set; }

        [Display(Name = "Comment")]
        public string ForumText { get; set; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        public IList<ForumPost> Results { get; set; }
    }
}
