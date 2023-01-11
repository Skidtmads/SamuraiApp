using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Samurai;
using Samurai.Models;

namespace Samurai.Repositories
{
    public class ArmortypeRepository : IArmortype
    {

        public static void CreateArmorTypeTable()
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "CREATE TABLE ArmorType (ArmorId INT, ArmorName NVARCHAR(50), SamuraiId INT)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddArmorType(int id, string name, int samuraiId)
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO ArmorType (Id, ArmorName, SamuraiId) VALUES (@id, @name, @samuraiId)";
                    command.Parameters.AddWithValue("@ArmorId", id);
                    command.Parameters.AddWithValue("@ArmorName", name);
                    command.Parameters.AddWithValue("@samuraiId", samuraiId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateArmorType(int id, string name, int samuraiId)
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "UPDATE ArmorType SET ArmorId = @Id ArmorName = @name, SamuraiId = @samuraid";
                    command.Parameters.AddWithValue("@Armorid", id);
                    command.Parameters.AddWithValue("@ArmorName", name);
                    command.Parameters.AddWithValue("@samuraiId", samuraiId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Create(Armortype armortype)
        {
            throw new NotImplementedException();
        }

        public void Update(Armortype armortype)
        {
            throw new NotImplementedException();
        }

        public void Delete(Armortype armortype)
        {
            throw new NotImplementedException();
        }

        public List<Armortype> getAllArmorType()
        {
            throw new NotImplementedException();
        }

        public Samurai getSamuraiWithArmortype(int samuraiId, int ArmortypeId)
        {
            throw new NotImplementedException();
        }
    }
}
