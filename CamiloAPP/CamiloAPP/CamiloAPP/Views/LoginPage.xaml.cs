using CamiloAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CamiloAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
        }

        //private void OnLoginButtonClicked(object sender, EventArgs e)
        //{
        //    string username = UsernameEntry.Text;
        //    string password = PasswordEntry.Text;

        //    if (username != null && password != null)
        //    {
        //        MenssageBienvenida.Text = "¡Bienvenido " + username + "!";
        //        MenssageBienvenida.TextColor = Color.Green;
        //        MenssageBienvenida.IsVisible = true;

        //    }
        //    else
        //    {
        //        MenssageBienvenida.Text = "¡Usuario o contraseña incorrectos pendejo!.";
        //        MenssageBienvenida.TextColor = Color.Red;
        //        MenssageBienvenida.IsVisible = true;
        //    }

        //}

    }
}