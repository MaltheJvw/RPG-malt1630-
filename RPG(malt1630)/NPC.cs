using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_malt1630_
{
    internal class NPC : Base
    {
        //Enum
        public enum NPCType
        {
            Human,
            Elf,
            Orc
        }

        //the paraters for NPC
        public NPC(string Name, int HP, int XP, NPCType type)
        {
            name = Name;
            hP = HP;
            xP = XP;
            Type = type;             
        }

        public override string ToString()
        {
            return $"NPCName: {name} HealthPoints : {hP} XP: {xP} Race: {Type} ";
        }




    }
}
