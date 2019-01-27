using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class ItemFactory
    {
        private static List<GameItem> _standardGameItems; // collection of the items in our game

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(0001, "Rusty Knife", 10, 3, 1, 3));
            _standardGameItems.Add(new Weapon(0002, "Knife", 30, 4, 2, 4));
            _standardGameItems.Add(new GameItem(0003, "Goblin Ear", 2, 1));
            _standardGameItems.Add(new GameItem(0004, "Goblin Fang", 3, 1));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            // creates item with specified itemTypeID (default is null)
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID); //LINQ query

            if (standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }
}
