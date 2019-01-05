using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged // so we can listen to a PropertyChanged event
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
                OnPropertyChanged("Name"); // trigers event handler
            }
        }
        public string CharacterClass
        {
            get { return _characterclass;  } 
            set
            {
                _characterclass = value;
                OnPropertyChanged("CharacterClass"); 
            }
        }
        public int HitPoints
        {
            get { return _hitpoints; }
            set
            {
                _hitpoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints // raises OnPropertyChanged event
        {
            get { return _experiencepoints; }
            set
            {
                _experiencepoints = value;
                OnPropertyChanged("ExperiencePoints"); // triggers event handler
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
