using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfApp1
{
    internal class Game : INotifyPropertyChanged
    {
        private string title;

        public List<string> gameTitles = new List<string> { "Game1", "Game2", "Game3", "Game4", "Game5" };

        public event PropertyChangedEventHandler? PropertyChanged;
        
        private void PropertyHasChanged( string string_in)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string_in));
        }

        public Game()
        {
        }

        public string gameTitle { 
            get
            {
                return title;
            }
            set
            {
                title = value;
                PropertyHasChanged("gameTitle");
            }
        }
        
        public void Randomize()
        {
            Random r = new Random();
            this.gameTitle = gameTitles[r.Next(gameTitles.Count)];
        }
    }
}
