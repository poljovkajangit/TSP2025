using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2025.Data.Model;

namespace TSP2025.DBServices
{
    public class GrupaMernihMestaDBService
    {
        public static IEnumerable<GrupaMernihMesta> GetAll()
        {
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand("Select Id, Naziv From GrupaMernihMesta", con);
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    foreach (DataRow grupaRow in ds.Tables[0].Rows)
                    {
                        yield return new GrupaMernihMesta
                        {
                            Id = (int)grupaRow["Id"],
                            Naziv = (string)grupaRow["Naziv"],
                        };
                    }
                }
            }
        }
    }
}
