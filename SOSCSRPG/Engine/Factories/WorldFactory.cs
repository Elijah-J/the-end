using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory // internal - only accessable within the same project 
    {
        internal static World CreateWorld()
        {
            World newWorld = new World(); // instantiates a new World object
            newWorld.AddLocation(0, -1, "Home", "This is your home", "/Engine;component/Images/Locations/house.png"); // home
            newWorld.AddLocation(0, 0, "Town Square", "This is the center of town", "/Engine;component/Images/Locations/town_square.png"); // town square
            newWorld.AddLocation(-1, -1, "Library", "This is the center of knowlege.", "/Engine;component/Images/Locations/library.jpg"); // library
            newWorld.AddLocation(1, -1, "Sue's Bakery", "This is where the best food in town is!", "/Engine;component/Images/Locations/bakery.png"); // Sue's bakery

            newWorld.LocationAt(1, -1).QuestList.Add(QuestFactory.GetQuestByID(1)); // add quest to our world

            newWorld.AddLocation(0, -2, "Mystic Lake", "There is an odd aura about this lake.", "/Engine;component/Images/Locations/mystic_lake.jpg"); // mystic lake
            newWorld.AddLocation(-2, 0, "Werewolf Grove", "Howling is heard here when the full moon rises.", "/Engine;component/Images/Locations/werewolf_grove.jpg"); // werewolf grove
            newWorld.AddLocation(-1, 0, "Hermit's Swamp", "This is the home of an old, scraggly man.", "/Engine;component/Images/Locations/hermits_swamp.jpg"); // hermit's swamp
            newWorld.AddLocation(1, 0, "Dead Man's Lake", "This is said to be home to the bodies of this town.", "/Engine;component/Images/Locations/dead_mans_lake.png"); // dead man's lake
            newWorld.AddLocation(0, 2, "Snowflake Summit", "This is the top of Snowflake Mountain!", "/Engine;component/Images/Locations/snowflake_summit.png"); // snowflake summit
            newWorld.AddLocation(0, 1, "Snowflake Mountain", "This is a foreboding mountain.", "/Engine;component/Images/Locations/snoflake_mountain.png"); // snowflake mountain
            return newWorld;
        }
    }
}
