using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using TSP2005;

namespace TSP2025.Data.Model
{
    public class Podstanica : ModelBase, IEntity
    {
        private Kotlarnica kotlarnica;
        private string naziv;
        private string? adresa;
        private string? odgovornoLice;
        private string? napomena;
        private string tABELA_NAPLATNOG_REGISTRA;
        private string kOLONA_NAPLANTONG_REGISTRA;

        public ImprovedBindingList<IndividualniPotrosac> IndividualniPotrosaci { get; set; }

        public Podstanica()
        {
            IndividualniPotrosaci = new ImprovedBindingList<IndividualniPotrosac>();
            IndividualniPotrosaci.BeforeRemove += IndividualniPotrosac_BeforeRemove;
        }
        private void IndividualniPotrosac_BeforeRemove(object deletedItem)
        {
            (deletedItem as IndividualniPotrosac).IsDeleted = true;
        }

        public required string Naziv
        {
            get => naziv;
            set
            {
                if (value != naziv)
                {
                    naziv = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Adresa
        {
            get => adresa;
            set
            {
                if (value != adresa)
                {
                    adresa = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? OdgovornoLice
        {
            get => odgovornoLice;
            set
            {
                if (value != odgovornoLice)
                {
                    odgovornoLice = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Napomena
        {
            get => napomena;
            set
            {
                if (value != napomena)
                {
                    napomena = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public required int KotlarnicaId { get; set; }
        public string TABELA_NAPLATNOG_REGISTRA
        {
            get => tABELA_NAPLATNOG_REGISTRA;
            set
            {
                if (value != tABELA_NAPLATNOG_REGISTRA)
                {
                    tABELA_NAPLATNOG_REGISTRA = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string KOLONA_NAPLANTONG_REGISTRA
        {
            get => kOLONA_NAPLANTONG_REGISTRA;
            set
            {
                if (value != kOLONA_NAPLANTONG_REGISTRA)
                {
                    kOLONA_NAPLANTONG_REGISTRA = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }

        public Kotlarnica Kotlarnica
        {
            get => kotlarnica;
            set
            {
                kotlarnica = value;
                kotlarnica.Podstanice.Add(this);
            }
        }
        public void Update()
        {
            try
            {
                using (var updateCommand = new SqlCommand())
                {
                    updateCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
                    updateCommand.Connection.Open();
                    updateCommand.CommandText = "Update Podstanica Set Naziv = @Naziv, Adresa = @Adresa, OdgovornoLice = @OdgovornoLice, Napomena = @Napomena, TABELA_NAPLATNOG_REGISTRA = @TNR, KOLONA_NAPLANTONG_REGISTRA = @KNR Where Id = @id";

                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OdgovornoLice", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.OdgovornoLice });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@TNR", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.TABELA_NAPLATNOG_REGISTRA });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@KNR", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.KOLONA_NAPLANTONG_REGISTRA });

                    updateCommand.ExecuteNonQuery();
                    updateCommand.Connection.Close();

                    this.IsChanged = false;
                    this.IsDeleted = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Create()
        {
            try
            {
                using (var insertCommand = new SqlCommand())
                {
                    using (insertCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string insertQuery = "Insert into Podstanica (Naziv, Adresa, OdgovornoLice, Napomena, KotlarnicaId, TABELA_NAPLATNOG_REGISTRA, KOLONA_NAPLANTONG_REGISTRA) output INSERTED.ID" +
                                                             " Values (@Naziv, @Adresa, @OdgovornoLice, @Napomena, @KotlarnicaId, @TABELA_NAPLATNOG_REGISTRA, @KOLONA_NAPLANTONG_REGISTRA)";
                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OdgovornoLice", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.OdgovornoLice });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@KotlarnicaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.KotlarnicaId });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@TABELA_NAPLATNOG_REGISTRA", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.TABELA_NAPLATNOG_REGISTRA });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@KOLONA_NAPLANTONG_REGISTRA", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.KOLONA_NAPLANTONG_REGISTRA });

                        insertCommand.Connection.Open();
                        int modified = (int)insertCommand.ExecuteScalar();
                        insertCommand.Connection.Close();

                        this.Id = modified;

                        this.IsChanged = false;
                        this.IsDeleted = false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete()
        {
            try
            {
                using (var deleteCommand = new SqlCommand())
                {
                    using (deleteCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string deleteQuery = "Delete From Podstanica Where Id=@Id";

                        deleteCommand.CommandText = deleteQuery;
                        deleteCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });

                        deleteCommand.Connection.Open();
                        deleteCommand.ExecuteNonQuery();
                        deleteCommand.Connection.Close();

                        this.IsChanged = true;
                        this.IsDeleted = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}