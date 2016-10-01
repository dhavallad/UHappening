using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UHappening
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private /*async*/ void Login_clicked(object sender, EventArgs e)
        {
            // do login operation.
            string username = UserName.Text.ToString();
            string password = Password.Text.ToString();

            if (username.ToLower() != "madhusudan" || password != "123")
            {
                errorMessage.Text = "Incorrect Credentials";
            }
            else
            {
                //await Navigation.PushAsync(new Temp());
                //on successfull login 
                App.Current.MainPage = new NavigationPage(new HomPage());
            }

        }
        private async void register_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegister());
            //App.Current.MainPage = new UserRegister();
        }
        private async void temp_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Temp());
        }
    }
}
