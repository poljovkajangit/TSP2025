using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using TSP2005;

namespace TSP2025.Data.Model
{
    public class Kotlarnica : ModelBase
    {
        private Toplana? _Toplana;
        private int toplanaId;
        private string naziv = string.Empty;
        private string? napomena;
        private string? adresa;
        private string? telefon;
        private string? sef;

        public Kotlarnica()
        {
            Podstanice = new ImprovedBindingList<Podstanica>();
            Podstanice.BeforeRemove += Podstanice_BeforeRemove;
        }

        private void Podstanice_BeforeRemove(object deletedItem)
        {
            (deletedItem as Podstanica).IsDeleted = true;
        }
        public ImprovedBindingList<Podstanica> Podstanice { get; set; }
        public required int ToplanaId { get => toplanaId; set => toplanaId = value; }
        public string Naziv
        {
            get => naziv;
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Napomena
        {
            get => napomena;
            set
            {
                if (napomena != value)
                {
                    napomena = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Adresa
        {
            get => adresa;
            set
            {
                if (adresa != value)
                {
                    adresa = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Telefon
        {
            get => telefon;
            set
            {
                if (telefon != value)
                {
                    telefon = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public string? Sef
        {
            get => sef;
            set
            {
                if (sef != value)
                {
                    sef = value;
                    IsChanged = PoslovniSistemDataContext.IsLoading ? false : true;
                }
            }
        }
        public required Toplana Toplana
        {
            get => _Toplana;
            set
            {
                _Toplana = value;
                _Toplana.Kotlarnice.Add(this);
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
                        string insertQuery = "Insert into Toplana (Naziv, Napomena) values (@Naziv, @Napomena)";

                        insertCommand.CommandText = insertQuery;
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });

                        insertCommand.Connection.Open();
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Connection.Close();

                        this.IsChanged = false;
                        this.IsDeleted = false;
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
                    using (updateCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                    {
                        string updateQuery = "Update Toplana Set Naziv=@Naziv, Napomena=@Napomena Where Id=@id";

                        updateCommand.CommandText = updateQuery;
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });

                        updateCommand.Connection.Open();
                        updateCommand.ExecuteNonQuery();
                        updateCommand.Connection.Close();

                        this.IsChanged = false;
                        this.IsDeleted = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
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
                        string deleteQuery = "Delete From Toplana Where Id=@Id";

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
