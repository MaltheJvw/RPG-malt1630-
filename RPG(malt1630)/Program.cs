using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RPG_malt1630_
{
    internal class Program : Base
    {
        static void Main(string[] args)
        {
            //Henrichs enemies
            NPC HumanNPC = new NPC("Human", 200, 10, NPC.NPCType.Human);
            NPC ElfNPC = new NPC("Elf", 120, 15, NPC.NPCType.Elf);
            NPC OrcNPC = new NPC("Orc", 600, 15, NPC.NPCType.Orc);

            //player object(the physical player) and weapon objects(the physical weapons from the list) 
            Player You = new Player("Henrick", "Human", 200);
            Equipment Sword = new Equipment("Sword", 30, 20);
            Equipment Spear = new Equipment("Spear", 17, 14);
            Equipment Shield = new Equipment("Shield", 80, 5);
            Equipment Gluten = new Equipment("Shield", 5, 1000);

            //decides which weapon to use to fight
            You.AddEquipment(Gluten);

            //decide which nps to fight
            You.AttackInput(OrcNPC); 

        }
    }
}
