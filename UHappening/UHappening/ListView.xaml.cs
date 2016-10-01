using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UHappening
{
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();

            MainList.ItemsSource = new List<Event>
            {
                 new Event
                {
                    name="Code : Debugging the Gender Gap",
                    type="Movie"

                },
                new Event
                {
                    name="Silent Disco",
                    type="Music"

                },
                new Event
                {
                    name="Candle Lighting",
                    type="Cultural"

                },
                new Event
                {
                    name="Tango Night",
                    type="Dance"

                },
                new Event
                {
                    name="Job Fair",
                    type="Job"
                }
            };
        }

        private void SearchEvents_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = SearchEvents.Text;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            //Have to know which item was clicked.
            await Navigation.PushAsync(new Temp());
        }

        private void MainList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //e.Item
        }

        private void MainList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var xyz = e.SelectedItem;
        }
    }
}
