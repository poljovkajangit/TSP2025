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
                    updateCommand.CommandText = "Update Podstanica Set Naziv = @Naziv, Adresa = @Adresa, OdgovornoLice = @OdgovornoLice, Napomena = @Napomena Where Id = @id";

                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OdgovornoLice", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.OdgovornoLice });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });

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
                        string insertQuery = "Insert into Podstanica (Naziv, Adresa, OdgovornoLice, Napomena, KotlarnicaId) output INSERTED.ID" +
                                                             " Values (@Naziv, @Adresa, @OdgovornoLice, @Napomena, @KotlarnicaId)";
                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@OdgovornoLice", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.OdgovornoLice });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@KotlarnicaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.KotlarnicaId });
            
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