using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CoasterProject.Models;

namespace CoasterProject.DAL
{
    public class ForumSqlDAO : IForumDAO
    {
        private string connectionString;
        public ForumSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets all the forum posts from DB.
        /// </summary>
        /// <returns></returns>
        public IList<ForumPost> GetPosts()
        {
            IList<ForumPost> forumPosts = new List<ForumPost>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlCommand = "SELECT * FROM ride_forum";
                    SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ForumPost forumPost = ConvertForumPostToReader(reader);
                        forumPosts.Add(forumPost);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }

            return forumPosts;
        }

        private ForumPost ConvertForumPostToReader(SqlDataReader reader)
        {
            ForumPost forumPost = new ForumPost();

            forumPost.Id = Convert.ToInt32(reader["id"]);
            forumPost.Username = Convert.ToString(reader["username"]);
            forumPost.Rating = Convert.ToInt32(reader["rating"]);
            forumPost.PostDate = Convert.ToDateTime(reader["post_date"]);
            forumPost.ForumTitle = Convert.ToString(reader["forum_title"]);
            forumPost.ForumText = Convert.ToString(reader["forum_text"]);

            return forumPost;
        }
    }
}
