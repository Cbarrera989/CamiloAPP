using CamiloAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CamiloAPP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private bool _ShowMessage;
        private string _WelcomeMessage;
        private Color _messagecolor;

        public string username
        {
            get => _username;
            set 
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }

            }
        }

        public string password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }

            }
        }

        public Color messagecolor
        {
            get => _messagecolor;
            set
            {
                if (_messagecolor != value)
                {
                    _messagecolor = value;
                    OnPropertyChanged();
                }

            }
        }

        public bool ShowMessage
        {
            get => _ShowMessage;
            set
            {
                if (_ShowMessage != value)
                {
                    _ShowMessage = value;
                    OnPropertyChanged();
                }

            }
        }

        public string WelcomeMessage
        {
            get => _WelcomeMessage;
            set
            {
                if (_WelcomeMessage != value)
                {
                    _WelcomeMessage = value;
                    OnPropertyChanged();
                }

            }
        }
        

        public Command LoginCommand { get; }

        public string UserName { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (ValidateFields())
            {
                if (username == "cbarrera" && password == "cbarrera")
                {
                    messagecolor = Color.Green;
                    WelcomeMessage = "¡Bienvenido! " + username + "!";                    
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
            }
            else
            {
                ShowMessage = true;
                messagecolor = Color.Red;
                WelcomeMessage = "Usuario o contraseña incorrectos";
            }
        }

        private bool ValidateFields()
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
