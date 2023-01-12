using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samurai.Models;

namespace Samurai.Models
{
    public interface IArmortype
    {
        public void Create(Armortype armortype);
        public void Update(Armortype armortype);
        public void Delete(Armortype armortype);
        public List<Armortype> getAllArmorType();
        public Samurai getSamuraiWithArmortype(int samuraiId, int ArmortypeId);
        
    }
}
