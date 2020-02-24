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
    public class GenresDataAccessLayer : IGenres
    {
        private string connectionString;
        public GenresDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }

        public int AddGenre(Genres genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createGenre", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Name", genre.Name);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<Genres> GetAllGenres()
        {
            try
            {
                List<Genres> genreslist = new List<Genres>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("readGenreAll", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Genres genre = new Genres();

                        genre.Id_Genre = Convert.ToInt32(reader["Id_Genre"]);
                        genre.Name = reader["Name"].ToString();

                        genreslist.Add(genre);
                    }
                    connection.Close();
                }
                return genreslist;
            }
            catch { throw; }
        }

        public Genres GetGenreById(int Id_Genre)
        {
            try
            {
                Genres genre = new Genres();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Genres WHERE Id_Genre= " + Id_Genre;
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        genre.Id_Genre = Convert.ToInt32(reader["Id_Genre"]);
                        genre.Name = reader["Name"].ToString();
                    }
                }
                return genre;
            }
            catch { throw; }
        }

        public int UpdateGenre(Genres genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("updateGenre", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", genre.Name);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch { throw; }
        }

        public int DeleteGenre(int Id_Genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deleteGenre", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_Genre", Id_Genre);

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
