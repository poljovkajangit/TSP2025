using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using TSP2005;

namespace TSP2025.Data.Model
{
    public class Kotlarnica : ModelBase
    {
        private Toplana _Toplana;
        private int toplanaId;
        private string naziv = string.Empty;
        private string napomena = string.Empty;
        private string adresa = string.Empty;
        private string telefon = string.Empty;
        private string sef = string.Empty;

        public Kotlarnica()
        {
            Podstanice = new ImprovedBindingList<Podstanica>();
            Podstanice.BeforeRemove += Podstanice_BeforeRemove;
        }

        private void Podstanice_BeforeRemove(object deletedItem)
        {
            (deletedItem as Podstanica)!.IsDeleted = true;
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
        public string Napomena
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
        public string Adresa
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
        public string Telefon
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
        public string Sef
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
        public Toplana Toplana
        {
            get => _Toplana!;
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
                        string insertQuery = "Insert into Kotlarnica (ToplanaId, Naziv, Napomena, Adresa, Telefon, Sef) output INSERTED.ID Values (@ToplanaId, @Naziv, @Napomena, @Adresa, @Telefon, @Sef)";

                        insertCommand.CommandText = insertQuery;

                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@ToplanaId", DbType = DbType.Int32, Direction = ParameterDirection.Input, Value = this.ToplanaId });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", DbType = DbType.String, Direction = ParameterDirection.Input, Value = this.Naziv });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", DbType = DbType.String, Direction = ParameterDirection.Input, Value = this.Napomena });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", DbType = DbType.String, Direction = ParameterDirection.Input, Value = this.Adresa });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Telefon", DbType = DbType.String, Direction = ParameterDirection.Input, Value = this.Telefon });
                        insertCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Sef", DbType = DbType.String, Direction = ParameterDirection.Input, Value = this.Sef });

                        insertCommand.Connection.Open();
                        int modified = (int)insertCommand.ExecuteScalar();
                        insertCommand.Connection.Close();

                        this.Id = modified;

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
                        string updateQuery = "Update Kotlarnica Set Naziv=@Naziv, Napomena=@Napomena, Adresa=@Adresa, Telefon=@Telefon, Sef=@Sef Where Id=@id";

                        updateCommand.CommandText = updateQuery;
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Id", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = this.Id });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Naziv", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Naziv });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Napomena", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Napomena });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Adresa", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Adresa });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Telefon", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Telefon });
                        updateCommand.Parameters.Add(new SqlParameter() { ParameterName = "@Sef", SqlDbType = SqlDbType.NText, Direction = ParameterDirection.Input, Value = this.Sef });

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
                        string deleteQuery = "Delete From Kotlarnica Where Id=@Id";

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
