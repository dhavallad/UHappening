using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UHappening
{
    public partial class HomPage : ContentPage
    {
        public HomPage()
        {
            InitializeComponent();
        }

        private async void createEventClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEvent());
        }
        private async void myEventsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView());
        }
    }
}
