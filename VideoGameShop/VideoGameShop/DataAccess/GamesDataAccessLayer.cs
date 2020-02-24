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
    public class GamesDataAccessLayer : IGames
    {
        private string connectionString;
        public GamesDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }

        public int AddGame(Games game)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createGame", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Name", game.Name);
                    command.Parameters.AddWithValue(@"Id_Dev", game.Id_Dev);
                    command.Parameters.AddWithValue(@"Cost", game.Cost);
                    command.Parameters.AddWithValue(@"Id_Genre", game.Id_Genre);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<Games> GetAllGames()
        {
            try
            {
                List<Games> gameslist = new List<Games>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("readGameAll", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Games game = new Games();

                        game.Name = reader["Name"].ToString();
                        game.Id_Dev = Convert.ToInt32(reader["Id_Dev"]);
                        game.Cost = Convert.ToDouble(reader["Cost"]);
                        game.Id_Genre = Convert.ToInt32(reader["Id_Genre"]);

                        gameslist.Add(game);
                    }
                    connection.Close();
                }
                return gameslist;
            }
            catch { throw; }
        }

        public Games GetGameById(int Id_Game)
        {
            try
            {
                Games game = new Games();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Games WHERE Id_Game= " + Id_Game;
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        game.Name = reader["Name"].ToString();
                        game.Id_Dev = Convert.ToInt32(reader["Id_Dev"]);
                        game.Cost = Convert.ToDouble(reader["Cost"]);
                        game.Id_Genre = Convert.ToInt32(reader["Id_Genre"]);
                    }
                }
                return game;
            }
            catch { throw; }
        }

        public int UpdateGame(Games game)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("updateGame", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Name", game.Name);
                    command.Parameters.AddWithValue(@"Id_Dev", game.Id_Dev);
                    command.Parameters.AddWithValue(@"Cost", game.Cost);
                    command.Parameters.AddWithValue(@"Id_Genre", game.Id_Genre);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }

        public int DeleteGame(int Id_Game)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deleteGame", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_Game", Id_Game);

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
