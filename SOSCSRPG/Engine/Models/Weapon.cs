using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem // this is a subclass
    {
        public Weapon(int itemTypeID, string name, int price, int weight) : base(itemTypeID, name, price, weight)
        {

        }
    }
}
