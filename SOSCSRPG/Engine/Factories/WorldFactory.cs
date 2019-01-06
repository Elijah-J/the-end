using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory // internal - only accessable within the same project
    {
        internal World CreateWorld()
        {
            World newWorld = new World(); // instantiates a new World object
            newWorld.AddLocation(0, -1, "Home", "This is your home", "/Engine;component/Images/Locations/house.png");
            return newWorld;
        }
    }
}
