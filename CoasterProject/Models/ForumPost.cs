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
        [Required(ErrorMessage = "Username must be at least 8 characters")]
        [MinLength(8)]
        public string Username { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Rating must be between 1 and 10")]
        [Range(1, 10)]
        public int Rating { get; set; }

        public DateTime PostDate { get; set; }

        [Display(Name = "Subject")]
        [Required]
        public string ForumTitle { get; set; }

        [Display(Name = "Comment")]
        [Required]
        public string ForumText { get; set; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        public IList<ForumPost> Results { get; set; }
    }
}
