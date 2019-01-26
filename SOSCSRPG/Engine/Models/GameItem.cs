using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem // public since it will be used in different projects
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public GameItem(int itemTypeID, string name, int price, int weight) 
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            Weight = weight;
        }

        // since the user will add to items, we will make a clone
        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, Weight);
        }
    }
}
