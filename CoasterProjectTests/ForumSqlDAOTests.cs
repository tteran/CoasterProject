using CoasterProject.DAL;
using CoasterProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoasterProjectTests
{
    [TestClass]
    public class ForumSqlDAOTests : CoasterDAOTests
    {
       [TestMethod]
       public void ListOfAllPosts_ShouldReturn_AllPosts()
        {
            ForumSqlDAO dao = new ForumSqlDAO(ConnectionString);
            IList<ForumPost> forumPosts = dao.GetPosts();
            Assert.AreEqual(1, forumPosts.Count);
        }
    }
}
