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
    public class UsersDataAccessLayer : IUsers
    {
        private string connectionString;
        public UsersDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }
        
        public int AddUser(Users user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createUser", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Money",user.Money);
                    command.Parameters.AddWithValue(@"Nickname",user.Nickname);
                    command.Parameters.AddWithValue(@"Password",user.Password);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<Users> GetAllUsers()
        {
            try
            {
                List<Users> userslist = new List<Users>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("readUserAll", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while(reader.Read())
                    {
                        Users user = new Users();

                        user.Id_User = Convert.ToInt32(reader["Id_User"]);
                        user.Money = Convert.ToDouble(reader["Money"]);
                        user.Nickname = reader["Nickname"].ToString();
                        user.Password = reader["Password"].ToString();

                        userslist.Add(user);
                    }
                    connection.Close();
                }
                return userslist;
            }
            catch { throw; }
        }

        public Users GetUserById(int Id_User)
        {
            try
            {
                Users user = new Users();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Users WHERE Id_User= " + Id_User;
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        user.Id_User = Convert.ToInt32(reader["Id_User"]);
                        user.Money = Convert.ToDouble(reader["Money"]);
                        user.Nickname = reader["Nickname"].ToString();
                        user.Password = reader["Password"].ToString();
                    }
                }
                return user;
            }
            catch { throw; }
        }

        public int UpdateUser(Users user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("updateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Money",user.Money);
                    command.Parameters.AddWithValue("@Nickname", user.Nickname);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }

        public int DeleteUser(int Id_User)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deleteUser",connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_User",Id_User);

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
