using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samurai;
using Samurai.Models;

namespace Samurai.Repositories
{
    public class SamuraiRepository : ISamurai
    {



        public static void CreateSamuraiTable()
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "CREATE TABLE Samurai (Id , Name NVARCHAR(50), ArmorType NVARCHAR(50), HorseId INT FOREIGN KEY)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSamurai(int id, string name, string armorType, int horseId)
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO Samurai (Id, Name, ArmorType, HorseId) VALUES (@id, @name, @armorType, @horseId)";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@armorType", armorType);
                    command.Parameters.AddWithValue("@horseId", horseId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateSamurai(int id, string name, string armorType, int horseId)
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "UPDATE Samurai SET Name = @name, ArmorType = @armorType, HorseId = @horseId, @samuraiId WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@armorType", armorType);
                    command.Parameters.AddWithValue("@horseId", horseId);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void create(Models.Samurai samurai)
        {
            throw new NotImplementedException();
        }

        public void update(Models.Samurai samurai)
        {
            throw new NotImplementedException();
        }

        public void delete(Models.Samurai samurai)
        {
            throw new NotImplementedException();
        }

        List<Models.Samurai> ISamurai.getAllSamurai()
        {
            throw new NotImplementedException();
        }

        Models.Samurai ISamurai.getSamuraiWithHorse(int samuraiId, int HorseId)
        {
            throw new NotImplementedException();
        }

        Models.Samurai ISamurai.getSamuraiWithHorse(string samuraiName, string horseName)
        {
            throw new NotImplementedException();
        }
    }
}
