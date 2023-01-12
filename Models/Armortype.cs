using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Opretter Armortype table med Id, navn og type
namespace Samurai.Models
{
    public class Armortype
    {
        public int Id { get; set; }
        public string? ArmorName { get; set; }
        public string? ArmorClass { get; set; }
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

    }
}
