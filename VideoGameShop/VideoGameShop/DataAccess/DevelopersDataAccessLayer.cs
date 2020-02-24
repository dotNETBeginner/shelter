using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameShop.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VideoGameShop.DataAccess
{
    public class DevelopersDataAccessLayer : IDevelopers
    {
        private string connectionString;
        public DevelopersDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }

        public int AddDeveloper(Developers developer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createDevelopers", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Name", developer.Name);
                    command.Parameters.AddWithValue(@"Id_Publisher", developer.Id_Publisher);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<Developers> GetAllDevelopers()
        {
            try
            {
                List<Developers> developerslist = new List<Developers>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("readDevelopersAll", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Developers developer = new Developers();

                        developer.Id_Dev = Convert.ToInt32(reader["Id_Dev"]);
                        developer.Name = reader["Name"].ToString();
                        developer.Id_Publisher = Convert.ToInt32(reader["Id_Publisher"]);

                        developerslist.Add(developer);
                    }
                    connection.Close();
                }
                return developerslist;
            }
            catch { throw; }
        }

        public Developers GetDeveloperById(int Id_Dev)
        {
            try
            {
                Developers developer = new Developers();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Developers WHERE Id_Dev= " + Id_Dev;
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        developer.Id_Dev = Convert.ToInt32(reader["Id_Dev"]);
                        developer.Name = reader["Name"].ToString();
                        developer.Id_Publisher = Convert.ToInt32(reader["Id_Publisher"]);
                    }
                }
                return developer;
            }
            catch { throw; }
        }

        public int UpdateDeveloper(Developers developer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("updateDevelopers", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Name", developer.Name);
                    command.Parameters.AddWithValue("@Id_Publisher", developer.Id_Publisher);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }

        public int DeleteDeveloper(int Id_Dev)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deleteDevelopers", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_Dev", Id_Dev);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }
    }
}
