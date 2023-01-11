using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai.Models
{
    public class Armortype
    {
        public int Id { get; set; } 
        public string? ArmorName { get; set; }
        public int SamuraiId { get; set; }
    }
}
