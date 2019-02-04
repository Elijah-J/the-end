using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotification
    {
        private Location _currentLocation; // our backing variable for the event handler
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = value;

                // Respond to event handler
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToSouth));
                OnPropertyChanged(nameof(HasLocationToEast));

                GivePlayerQuestsAtLocation(); // gives our player the quest
            }
        }
        public World CurrentWorld { get; set; }

        public bool HasLocationToNorth
        {
            get
            {
                // tries to get location at specified coordinate and checks whether it is null
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                // tries to get location at specified coordinate and checks whether it is null
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                // tries to get location at specified coordinate and checks whether it is null
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                // tries to get location at specified coordinate and checks whether it is null
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public GameSession()
        {
            CurrentPlayer = new Player // object literal - improves readability
            {
                Name = "Eli",
                CharacterClass = "Monk",
                HitPoints = 10,
                Gold = 1000000,
                ExperiencePoints = 0,
                Level = 1,
            };

            CurrentWorld = WorldFactory.CreateWorld(); // we only use this once - so we make this static
            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }

        // These following functions will be called by our UI

        public void MoveNorth() // all of these will contain guard clauses
        {
            if (HasLocationToNorth)
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.QuestList) // looks at each quest in current location
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID)) // if the player does not have this quest
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

    }            
}
