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

        public bool SavePost(ForumPost newPost)
        {
            bool wasPostAdded;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    string sqlCommand = $"INSERT INTO ride_forum (username, rating, forum_title, forum_text)" +
                                        "VALUES (@username, @rating, @forum_title, @forum_text)";
                    SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                    cmd.Parameters.AddWithValue("@username", newPost.Username);
                    cmd.Parameters.AddWithValue("@rating", newPost.Rating);
                    cmd.Parameters.AddWithValue("@forum_title", newPost.ForumTitle);
                    cmd.Parameters.AddWithValue("@forum_text", newPost.ForumText);

                    cmd.ExecuteNonQuery();

                    wasPostAdded = true;
                }
            }
            catch(SqlException ex)
            {
                wasPostAdded = false;
                throw;
            }

            return wasPostAdded;

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
