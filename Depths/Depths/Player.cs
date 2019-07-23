using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Player
    {
        //Basic Stats
        public int HP { get; set; }
        public int Energy { get; set; }
        public int MentalPower { get; set; }
        public int Defence { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }

        //Advanced Stats
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Willpower { get; set; }
        public int Personality { get; set; }

        //Equipment Stats 

        public Weapon PlayerWeapon { get; set; }
        public Armor PlayerArmor { get; set; }

        // Inventory Stats
        public List<Items> Inventory {get; set;}
        public int Gold {get; set;}

        //Other Stats
        
    }
}
