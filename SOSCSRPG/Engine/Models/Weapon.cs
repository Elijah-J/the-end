using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem // this is a subclass
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, int weight, int minDamage, int maxDamage) : 
            base(itemTypeID, name, price, weight) // sets properties in base class
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        // include new so we can override the gameItem version of this function
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, Weight, MinimumDamage, MaximumDamage);
        }
    }
}
