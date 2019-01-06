using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>(); // we will use WorldFactory 
                                                                  // to load this list

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName) // internal because only WorldFactory class should access this
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);
        }

        // Returns location at entered x-coord and y-coord
        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            // chedck objects in our list
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
