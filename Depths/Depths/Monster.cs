using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Monster
    {
        public int HP { get; set; }
        public int Energy { get; set; }
        public int MentalPower { get; set; }
        public int Defence { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }

        public int GoldDroppedOnDeath { get; set; }
        public int ExpAwardedToPlayer { get; set; }

        public string Description { get; set; }
    }
}
