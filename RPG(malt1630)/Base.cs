using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_malt1630_.NPC;

namespace RPG_malt1630_
{
    internal class Base
    {
        //Field

        public int XP;

        public string race;
        public string name { get; set; }
        public int hP { get; set; }

        public int xP { get; set; }

        public NPCType Type { get; set; }
      

        // A loop that lets Henrich attack untill npc is dead
        public void AttackNPC(Player player, NPC npc)
        {
            {
                //counts the many hits it took to defeat the enemy
                int hitCount = 0;
                while (npc.hP > 0)
                {
                    int damage = CalculateDamage(player);
                    DealDamage(npc, damage);
                    hitCount++;
                }
            }
        }

        //Calculates the damage Henrich does with his chosen weapon
        private int CalculateDamage(Player player)
        {
            if (player.Inventory.Count > 0)
            {
                Equipment weapon = player.Inventory[0];
                return weapon.damage;
            }
            return 0;
        }

        //deals damage to chosen npc with the calculated damage
        private void DealDamage(NPC npc, int damage)
        {
            npc.hP -= damage;
            Console.WriteLine($"Dealt {damage} damage to {npc.name}. NPC's HP: {npc.hP}");

            if (npc.hP <= 0)
            {
                Console.WriteLine($"{npc.name} has been defeated!");
            }
        }

        //virtual auto attack result allowing a overrride from a different class.(Player)
        public virtual void AttackInput(NPC npc)
        {

        }

    }
}
