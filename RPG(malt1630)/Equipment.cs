using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_malt1630_
{
    internal class Equipment : Player
    {

        public string weaponName { get; set; }
        public int weight { get; set; }
        public int damage { get; set; }
        public string? Weaponname { get; internal set; }

        public Equipment(string Weaponname, int Weight, int Damage) 
        {
            weaponName = Weaponname;
            weight = Weight;
            damage = Damage;
        }

        public override string ToString()
        {
            return $"{weaponName} - Weight: {weight} - Damage: {damage}";
        }
    }
}
