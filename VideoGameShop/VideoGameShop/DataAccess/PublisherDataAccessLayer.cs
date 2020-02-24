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
    public class PublisherDataAccessLayer : IPublishers
    {
        private string connectionString;
        public PublisherDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }

        public int AddPublisher(Publishers publisher)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createPublisher", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Name", publisher.Name);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<Publishers> GetAllPublishers()
        {
            try
            {
                List<Publishers> publisherslist = new List<Publishers>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("readPublisherAll", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Publishers publisher = new Publishers();

                        publisher.Id_Publisher = Convert.ToInt32(reader["Id_Publisher"]);
                        publisher.Name = reader["Money"].ToString();

                        publisherslist.Add(publisher);
                    }
                    connection.Close();
                }
                return publisherslist;
            }
            catch { throw; }
        }

        public Publishers GetPublisherById(int Id_Publisher)
        {
            try
            {
                Publishers publisher = new Publishers();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Publishers WHERE Id_Publisher= " + Id_Publisher;
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        publisher.Id_Publisher = Convert.ToInt32(reader["Id_Publisher"]);
                        publisher.Name = reader["Name"].ToString();
                    }
                }
                return publisher;
            }
            catch { throw; }
        }

        public int UpdatePublishers(Publishers publisher)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("updatePublisher", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", publisher.Name);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }

        public int DeletePublishers(int Id_Publisher)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deletePublisher", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_Publisher", Id_Publisher);

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
