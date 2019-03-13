using CoasterProject.DAL;
using CoasterProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoasterProjectTests
{
    [TestClass]
    public class RollerCoasterSqlDAOTests : CoasterDAOTests
    {
       [TestMethod]
       public void List_Of_All_RollerCoasters_ShouldReturn_AllListedRollerCoasters()
        {
            RollerCoasterSqlDAO dao = new RollerCoasterSqlDAO(ConnectionString);
            IList<RollerCoaster> rollerCoasters = dao.GetCoasters();
            Assert.AreEqual(1, rollerCoasters.Count);
        }
    }
}
