using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    internal class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // declare items needed to complete the quest, and items rewarded
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(1003, 3));
            itemsToComplete.Add(new ItemQuantity(1004, 2));

            rewardItems.Add(new ItemQuantity(1002, 1));

            // Create the quest
            _quests.Add(new Quest(
                            1,
                            "Clear the goblins!",
                            "Goblins have infested the bakery. Clear them out!",
                            itemsToComplete,
                            25, // experience
                            20, // gold
                            rewardItems
                            ));
        }
    }
}
