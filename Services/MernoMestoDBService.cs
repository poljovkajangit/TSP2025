using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2025.Data.Model;
using TSP2025.Utils;

namespace TSP2025.DB
{
    public static class MernoMestoDBService
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
                catch (Exception ex)
                {
                    FormMessages.ShowError("Greška. " + ex.Message);
                }
            }
        }
        public static IEnumerable<MernoMesto> GetAll()
        {
            using (var ds = new DataSet())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    var cmd = new SqlCommand(
                        "Select mm.Id, mm.OznakaKalorimetra, mm.OznakaMernogMesta, mm.Tip, mm.PotrosacId, mm.ScadaTabela, mm.ScadaKolona, mm.VremeDodavanja, g.Naziv, g.Id as GrupaId " +
                        "From MernoMesto mm join GrupaMernihMesta g on g.Id = mm.GrupaMernogMestaId ", con);

                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    foreach (DataRow mernoMestoRow in ds.Tables[0].Rows)
                    {
                        yield return new()
                        {
                            Id = (int)mernoMestoRow["Id"],
                            GrupaMernogMesta = new GrupaMernihMesta() { Id = (int)mernoMestoRow["GrupaId"], Naziv = (string)mernoMestoRow["Naziv"], ImaMernoMesto = false },
                            OznakaKalorimetra = (string)mernoMestoRow["OznakaKalorimetra"],
                            OznakaMernogMesta = (string)mernoMestoRow["OznakaMernogMesta"],
                            Tip = (int)mernoMestoRow["Tip"],
                            PotrosacId = (int)mernoMestoRow["PotrosacId"],
                            GrupaMernogMestaId = (int)mernoMestoRow["GrupaId"],
                            VremeDodavanja = (DateTime)mernoMestoRow["VremeDodavanja"],
                            ScadaKolona = (string)mernoMestoRow["ScadaKolona"],
                            ScadaTabela = (string)mernoMestoRow["ScadaTabela"],
                        };
                    }
                }
            }
        }

        public static IEnumerable<MernoMesto> GetAllByOznakaMernogMesta(string oznakaMernogMesta)
        {

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var command = new SqlCommand
                    (
                        "Select mm.Id, mm.OznakaKalorimetra, mm.OznakaMernogMesta, mm.Tip, mm.PotrosacId, mm.ScadaTabela, mm.ScadaKolona, mm.VremeDodavanja, g.Naziv, g.Id as GrupaId " +
                        "From MernoMesto mm join GrupaMernihMesta g on g.Id = mm.GrupaMernogMestaId " +
                        "Where mm.OznakaMernogMesta like '%" + oznakaMernogMesta + "%' ", connection);

                SqlDataReader reader = null;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    FormMessages.ShowError("Greška. " + ex.Message);
                }

                while (reader.Read())
                {
                    yield return new()
                    {
                        Id = reader.GetInt32("Id"),
                        GrupaMernogMesta = new GrupaMernihMesta()
                        {
                            Id = reader.GetInt32("GrupaId"),
                            Naziv = reader.GetString("Naziv"),
                        },
                        OznakaKalorimetra = reader.GetString("OznakaKalorimetra"),
                        OznakaMernogMesta = reader.GetString("OznakaMernogMesta"),
                        Tip = reader.GetInt32("Tip"),
                        PotrosacId = reader.GetInt32("PotrosacId"),
                        GrupaMernogMestaId = reader.GetInt32("GrupaId"),
                        VremeDodavanja = reader.GetDateTime("VremeDodavanja"),
                        ScadaKolona = reader.GetString("ScadaKolona"),
                        ScadaTabela = reader.GetString("ScadaTabela"),
                    };
                }
                reader.Close();
            }
        }
    }
}
