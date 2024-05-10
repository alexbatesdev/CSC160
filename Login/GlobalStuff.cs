using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class GlobalStuff : INotifyPropertyChanged
    {
        public static string user;
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                DoPropertyAlert("Username");
            }
        }


        public static LoginPage loginPage;
        public static SignUp signUpPage;
        public static Home homePage;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void DoPropertyAlert(string string_in)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string_in));
        }
        public GlobalStuff()
        {
            Username = user;
        }
        
    }
}
