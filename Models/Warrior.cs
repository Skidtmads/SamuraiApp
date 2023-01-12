using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Opretter Warrior table med Id, Navn, Armortype og Heste Id
namespace Samurai.Models
{
    public class Warrior
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Armortype { get; set; }
        public int HorseId { get; set; }

        public void create(Warrior warrior)
        {
            throw new NotImplementedException();
        }

        public void update(Warrior warrior)
        {
            throw new NotImplementedException();
        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Warrior> getAllWarriors()
        {
            throw new NotImplementedException();
        }

        
    }
}

