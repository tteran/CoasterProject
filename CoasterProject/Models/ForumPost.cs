using System;
using System.Collections.Generic;
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
        public string Username { get; set; }
        public int Rating { get; set; }
        public DateTime PostDate { get; set; }
        public string ForumTitle { get; set; }
        public string ForumText { get; set; }
    }
}
