using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Opretter Heste table med Id, Navn, Armortype og WarriorId (rytter)
namespace Samurai.Models
{
    public class Horses
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Armortype { get; set; }
        public int WarriorId { get; set; }

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
    
}
