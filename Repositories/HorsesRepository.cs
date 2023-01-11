using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Samurai;
using Samurai.Models;

namespace Samurai.Repositories;

    public class HorsesRepository : IHorses
    {
                  
        

        public static void CreateHorsesTable()
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "CREATE TABLE Horses (Id INT PRIMARY KEY, Name NVARCHAR(50), ArmorType NVARCHAR(50), SamuraiId INT)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddHorse(int id, string name, string armorType, int samuraiId)
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO Horses (Id, Name, ArmorType, SamuraiId) VALUES (@id, @name, @armorType, @samuraiId)";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@armorType", armorType);
                    command.Parameters.AddWithValue("@samuraiId", samuraiId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateHorse(int id, string name, string armorType, int samuraiId)
        {
            using (var connection = new SqlConnection("Data Source=9700K\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "UPDATE Horses SET Name = @name, ArmorType = @armorType, SamuraiId = @samuraiId WHERE Id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@armorType", armorType);
                    command.Parameters.AddWithValue("@samuraiId", samuraiId);
                    command.ExecuteNonQuery();
                }
            }
        }

    public void create(Horses horses)
    {
        throw new NotImplementedException();
    }

    public void update(Horses horses)
    {
        throw new NotImplementedException();
    }

    public void delete(int HorseId)
    {
        throw new NotImplementedException();
    }

    public List<Horses> getAllHorses()
    {
        throw new NotImplementedException();
    }

    public Horses getHorses(int horseId)
    {
        throw new NotImplementedException();
    }
}


