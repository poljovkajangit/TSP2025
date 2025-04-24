using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TSP2025.DB
{
    public static class MernoMesto
    {
        public static void Delete(int id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var command = new SqlCommand("Delete From MernoMesto Where Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
