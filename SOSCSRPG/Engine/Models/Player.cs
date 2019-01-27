using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BaseNotification
        // so we can listen to a PropertyChanged event
    {
        // these are our backing variables
        private string _name;
        private string _characterclass;
        private int _hitpoints;
        private int _experiencepoints;
        private int _level;
        private int _gold;

        public string Name
        {
            get { return _name;  } // returns value from backing variable
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name)); // trigers event handler
            }
        }
        public string CharacterClass
        {
            get { return _characterclass;  } 
            set
            {
                _characterclass = value;
                OnPropertyChanged(nameof(CharacterClass)); 
            }
        }
        public int HitPoints
        {
            get { return _hitpoints; }
            set
            {
                _hitpoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints // raises OnPropertyChanged event
        {
            get { return _experiencepoints; }
            set
            {
                _experiencepoints = value;
                OnPropertyChanged(nameof(ExperiencePoints)); // triggers event handler
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        // for our inventory
        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

    }
}
