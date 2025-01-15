using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TSP2025.Data.Model
{
    public class IndividualniPotrosac : ModelBase, IEntity
    {
        private Podstanica? podstanica;
        private string naziv;
        private string? adresa;
        private string? email;
        private string? telefon;

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
        public string? Email
        {
            get => email;
            set
            {
                if (value != email)
                {
                    email = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Telefon
        {
            get => telefon;
            set
            {
                if (value != telefon)
                {
                    telefon = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public required int PodstanicaId { get; set; }

        public Podstanica Podstanica
        {
            get => podstanica;
            set
            {
                podstanica = value;
                podstanica.IndividualniPotrosaci.Add(this);
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
                        string insertQuery = "Insert into IndividualniPotrosac (Naziv, Adresa, Email, Telefon, PodstanicaId) output INSERTED.ID " +
                                                             " Values (@Naziv, @Adresa, @Email, @Telefon, @PodstanicaId)";
                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Email", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Email });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Telefon", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Telefon });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@PodstanicaId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.PodstanicaId });


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
                        string deleteQuery = "Delete From IndividualniPotrosac Where Id=@Id";

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

        public void Update()
        {
            try
            {
                using (var updateCommand = new SqlCommand())
                {
                    updateCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
                    updateCommand.Connection.Open();
                    updateCommand.CommandText = "Update IndividualniPotrosac Set Naziv = @Naziv, Adresa = @Adresa, Email = @Email, Telefon = @Telefon Where Id = @id";

                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Email", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Email });
                    updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Telefon", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Telefon });

                    updateCommand.ExecuteNonQuery();
                    updateCommand.Connection.Close();

                    this.IsChanged = false;
                    this.IsDeleted = false;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}