using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_malt1630_
{
    internal class Player : Base
    {
       
        //a list called equipment where the weapons are saved untill called.
        private List<Equipment> inventory = new();
        
        //Empty Construct
        public Player()
        {
            
        }

        //construct with Player parameters
        public Player(string Name, string Race, int HP) 
        {
            name = Name;
            race = Race;
            hP = HP;
            inventory = new List<Equipment>();
        }

        // giving property to the list object
        public List<Equipment> Inventory
        {
            get { return inventory; }
        }

        //add weapon to the list 
        public void AddEquipment(Equipment equipment)
        {
            inventory.Add(equipment);
        }

        public override string ToString()
        {
            return $"{name} - {race} - {hP} - Inventory: {string.Join(", ", inventory.Select(e => e.Weaponname))}";
        }

        //attack npc method
        public void Attack(NPC npc)
        {
            AttackNPC(this, npc);
        }

        //this is a method that allows a input for attack. it will override the method in base of same name.
        public override void AttackInput(NPC npc)
        {
            Console.WriteLine($"You have encountered a {npc.name}!");
            Console.WriteLine("Press A to attack: ");
            string PlayerInput = Console.ReadLine().ToUpper();

            if (PlayerInput == "A")
            {
                Attack(npc);
            }
        }

        

    }
}
