using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samurai.Models;

namespace Samurai.Models
{
    public interface ISamurai
    {
        public void create(Samurai samurai);
        public void update(Samurai samurai);
        public void delete(Samurai samurai);
        public List<Samurai> getAllSamurai();
        public Samurai getSamuraiWithHorse(int samuraiId, int HorseId);
        public Samurai getSamuraiWithHorse(string samuraiName, string horseName);
    }
}
