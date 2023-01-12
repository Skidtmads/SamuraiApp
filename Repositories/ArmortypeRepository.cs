using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Samurai;
using Samurai.Models;
// Opretter ArmorType som table i SQL, gør entries justerbare og sletbare.
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
                        "CREATE TABLE ArmorType (ArmorId INT, ArmorName NVARCHAR(50), WarriorId INT)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddArmorType(int id, string name, int warriorId)
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO ArmorType (Id, ArmorName, WarriorId) VALUES (@id, @name, @warriorId)";
                    command.Parameters.AddWithValue("@ArmorId", id);
                    command.Parameters.AddWithValue("@ArmorName", name);
                    command.Parameters.AddWithValue("@warriorId", warriorId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateArmorType(int id, string name, int warriorId)
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "UPDATE ArmorType SET ArmorId = @Id ArmorName = @name, WarriorId = @warriorId";
                    command.Parameters.AddWithValue("@Armorid", id);
                    command.Parameters.AddWithValue("@ArmorName", name);
                    command.Parameters.AddWithValue("@warriorId", warriorId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteArmorType(int id, string name, int warriorId)
        {
            using (var connection = new SqlConnection("Data Source=9700K;Integrated Security=True;Connect Timeout=240;Encrypt=False;ApplicationIntent=ReadWrite"))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "DELETE ArmorType (Id, ArmorName, WarriorId) VALUES (@id, @name, @warriorId)";
                    command.Parameters.AddWithValue("@ArmorId", id);
                    command.Parameters.AddWithValue("@ArmorName", name);
                    command.Parameters.AddWithValue("@warriorId", warriorId);
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

        public IWarrior getSamuraiWithArmortype(int warrioId, int ArmortypeId)
        {
            throw new NotImplementedException();
        }

        Models.Warrior IArmortype.getWarriorWithArmortype(int warriorId, int ArmortypeId)
        {
            throw new NotImplementedException();
        }
    }
}
