using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class Utilities
    {
        //@"Data Source=DBSrv\SQL2021;Initial Catalog=MyChat;Integrated Security=True";
        public readonly static string connectionString = @"Data Source=DESKTOP-M7EVVNL\SQLEXPRESS;Initial Catalog=MyChat;Integrated Security=True";
        public class Methods
        {
            public static void UpdateUserStatus(string user, string status)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    string query = "Update Users set StatusId = @StatusId where Nickname = @Nickname";
                    connection.Open();
                    SqlCommand command = new(query, connection);
                    if (status == "Online") command.Parameters.AddWithValue("StatusId", 1);
                    if (status == "Offline") command.Parameters.AddWithValue("StatusId", 2);
                    command.Parameters.AddWithValue("Nickname", user);
                    command.ExecuteNonQuery();
                }
            }

            public static string CheckUserStatus(string user)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    string query = "SELECT  Statuses._name FROM Users " +
                        "INNER JOIN Statuses ON Users.StatusId = Statuses.Id " +
                        "WHERE Users.Nickname = @Username";
                    connection.Open();
                    SqlCommand command = new(query, connection);
                    command.Parameters.AddWithValue("Nickname", user);
                    SqlDataReader reader = command.ExecuteReader();
                    return reader.Read().ToString();
                }
            }
        }
    }
}
