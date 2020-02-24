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
    public class PurchaseDataAccessLayer : IUserLibraryRelativeTable
    {
        private string connectionString;
        public PurchaseDataAccessLayer(IConfiguration configuration)
        { connectionString = configuration["ConnectionStrings:DefaultConnection"]; }

        public int AddPurchase(UserLibraryRelativeTable purchase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("createPurchase", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(@"Id_User", purchase.Id_User);
                    command.Parameters.AddWithValue(@"Id_Game", purchase.Id_Game);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return 1;
            }
            catch
            { throw; }
        }

        public IEnumerable<UserLibraryRelativeTable> GetAllPurchase()
        {
            try 
            { 
            List<UserLibraryRelativeTable> purchaseslist = new List<UserLibraryRelativeTable>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("readPurchaseAll", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserLibraryRelativeTable purchase = new UserLibraryRelativeTable();

                    purchase.Id_Purchase = Convert.ToInt32(reader["Id_Purchase"]);
                    purchase.Id_User = Convert.ToInt32(reader["Id_User"]);
                    purchase.Id_Game = Convert.ToInt32(reader["Id_Game"]);

                        purchaseslist.Add(purchase);
                        

                }
                connection.Close();
            }
                return purchaseslist;
            }
            catch { throw; }
        }

        public UserLibraryRelativeTable GetPurchaseById(int Id_Purchase)
        {
            try
            {
                UserLibraryRelativeTable purchase = new UserLibraryRelativeTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //string sqlQuery = "SELECT * FROM UserLibraryRelativeTable WHERE Id_Purchase= " + Id_Purchase;
                    SqlCommand command = new SqlCommand("readPurchaseById", connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        purchase.Id_Purchase = Convert.ToInt32(reader["Id_Purchase"]);
                        purchase.Id_User = Convert.ToInt32(reader["Id_User"]);
                        purchase.Id_Game = Convert.ToInt32(reader["Id_Game"]);
                    }
                }
                return purchase;
            }
            catch { throw; }
        }

        public int DeletePurchase(int Id_Purchase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("deletePurchase", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id_Purchase", Id_Purchase);

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
