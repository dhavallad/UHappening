using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UHappening
{
    public partial class Temp : ContentPage
    {
        public Temp()
        {
            InitializeComponent();
            pickerNotificationDate.SetValue(DatePicker.MinimumDateProperty, DateTime.Now);
        }
        public Temp(Page p)
        {
            InitializeComponent();
             
        }

        private async void IsPrivateClicked(object sender, EventArgs e)
        {
            string[] input = new string[] { "Yes", "No" };
            string value = await DisplayActionSheet("Private Event ? ", "cancel", "", input);
            if (value != null && value == "Yes")
            {
                isPrivate.Text = "Yes";
            }
            else if (value != null && value == "No")
            {
                isPrivate.Text = "No";
            }
        }
    }
}
