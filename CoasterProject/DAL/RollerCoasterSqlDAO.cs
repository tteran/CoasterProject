using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CoasterProject.Models;

namespace CoasterProject.DAL
{
    public class RollerCoasterSqlDAO : IRollerCoasterDAO
    {
        private string connectionString;
        public RollerCoasterSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<RollerCoaster> GetCoasters()
        {
            IList<RollerCoaster> rollerCoasters = new List<RollerCoaster>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement = "SELECT * FROM cedar_point_coasters";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        RollerCoaster rollerCoaster = ConvertReaderToRollerCoaster(reader);
                        rollerCoasters.Add(rollerCoaster);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return rollerCoasters;
        }

        private RollerCoaster ConvertReaderToRollerCoaster(SqlDataReader reader)
        {
            RollerCoaster rollerCoaster = new RollerCoaster();

            rollerCoaster.Name = Convert.ToString(reader["name"]);
            rollerCoaster.BuildYear = Convert.ToInt32(reader["build_year"]);
            rollerCoaster.Speed = Convert.ToInt32(reader["speed"]);
            rollerCoaster.Height = Convert.ToInt32(reader["height"]);
            rollerCoaster.Duration = Convert.ToInt32(reader["duration"]);
            rollerCoaster.Description = Convert.ToString(reader["description"]);
            rollerCoaster.MinHeight = Convert.ToInt32(reader["min_height"]);
            rollerCoaster.RideVideo = Convert.ToString(reader["ride_video"]);
            rollerCoaster.RideImage = Convert.ToString(reader["ride_image"]);

            return rollerCoaster;
        }
    }
}
