using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DnDCharacterGen
{
    internal class Character : INotifyPropertyChanged
    {
        public Character()
        {
            name = "";
            age = 22;
            sex = true;
            gender = 0.7f;
            DnDClass = "Fighter";
            Race = "Human";
        }
        
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChangeUpdate("Name");
            }
        }

        List<string> names = new List<string> { "Shamuel", "Gregary", "Simion", "Hibertt", "Bert", "Shim Slady", "Gurt", "Junith", "Grimbledy", "Oonai", "Grallathan", "Grimble", "Hogarth", "Sheamus" };

        // Range based on race
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                PropertyChangeUpdate("Age");
            }
        }
        
        // Classic true == cock false != cock
        private bool sex;
        public bool Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
                PropertyChangeUpdate("Sex");
            }
        }

        // Range 0-1
        private float gender;
        public float Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                PropertyChangeUpdate("Gender");
            }
        }

        private string DnDclass;
        public string DnDClass
        {
            get
            {
                return DnDclass;
            }
            set
            {
                DnDclass = value;
                PropertyChangeUpdate("DnDClass");
            }
        }

        List<string> classes = new List<string> { "Fighter", "Barbarian", "Warlock", "Paladin", "Druid", "Sorcerer", "Ranger", "Rogue", "Bard" };

        private string race;
        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
                PropertyChangeUpdate("Race");
            }
        }

        List<string> races = new List<string> { "Human", "Elf", "Tiefling", "Dwarf", "Halfling", "Warforged", "Drow", "DragonBorn", "Skeleton", "Magic Dog", "Candy Elemental", "Half-Elf" };

        public event PropertyChangedEventHandler? PropertyChanged;

        private void PropertyChangeUpdate(string string_in)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string_in));
        }

        public void Randomize(string name)
        {
            Random r = new Random();
            if (name.Count() > 0)
            {
                Name = name;
            } else
            {
                Name = names[r.Next(names.Count)];
            }

            Age = r.Next(900);
            if (r.Next(2) % 2 == 0)
            {
                Sex = true;
            } else
            {
                Sex = false;
            }
            Gender = (float) r.NextDouble();
            DnDClass = classes[r.Next(classes.Count)];
            Race = races[r.Next(races.Count)];
        }
    }
}
