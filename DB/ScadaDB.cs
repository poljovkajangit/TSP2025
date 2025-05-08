using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TSP2025.DB
{
    public static class ScadaDb
    {
        public static void ClearAllScadaPull()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var command = new SqlCommand("Truncate table Ocitavanje; Truncate table Pullhistory;", connection);
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
