using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;


namespace CoasterProjectTests
{
    [TestClass]
    public class CoasterDAOTests
    {      
        protected string ConnectionString { get; } = "Data Source=.\\SQLEXPRESS;Initial Catalog=CoasterSideProject;Integrated Security=True";

        private TransactionScope transaction;

        protected int RollerCoasterId { get; private set; }

        protected int RideForumId { get; private set; }

        [TestInitialize]
        public void Setup()
        {
            transaction = new TransactionScope();

            string sql = File.ReadAllText("test-script.sql");

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    this.RollerCoasterId = Convert.ToInt32(reader["newCedarPointCoastersId"]);
                    this.RideForumId = Convert.ToInt32(reader["newRideForumId"]);
                }
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Rollback transaction
            transaction.Dispose();
        }

        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    }
}
