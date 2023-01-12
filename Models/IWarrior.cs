using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samurai.Models;

namespace Samurai.Models
{
    public interface IWarrior
    {
        public void create(Warrior warrior);
        public void update(Warrior warrior);
        public void delete(Warrior warrior);
        public List<Warrior> getAllWarriors();
        public Warrior getWarriorWithHorse(int warriorId, int HorseId);
        public Warrior getWarriorWithHorse(string warriorName, string horseName);
    }
}
