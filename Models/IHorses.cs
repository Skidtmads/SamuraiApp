using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samurai.Models;

namespace Samurai.Models
{
    public interface IHorses
    {
        public void create(Horses horses);
        public void update(Horses horses);
        public void delete(int HorseId);
        public List<Horses> getAllHorses();
        public Horses getHorses(int horseId);
        
    }
}
