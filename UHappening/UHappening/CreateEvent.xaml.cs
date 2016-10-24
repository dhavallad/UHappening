using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Xamarin.Forms;

namespace UHappening
{
	public partial class CreateEvent : ContentPage
	{
		public CreateEvent()
		{
			//eventName.Text = "";
			//eventDescription.Text = "";
			//IsPrivateSwitch.IsEnabled = true;
			//eventType.SelectedIndex = 1;
			//eventlocation.Text = "asd";
			//eventStart.Text = "1212";
			//eventEnd.Text = "12121212";
			//eventCapacity.Text = "12";


			InitializeComponent();

			//Intialize the picker by getting all the event types from the database.
			//Or hardcode if retrieveing is a problem or time consuming


			//eventType.Items.Add();
		}
		private void CreateEventClicked(object sender, EventArgs e)
		{
			// Do basic validation.
			// save values to database. using webservice


			//string connectionString = "Data Source=SAIRAM-PC;Initial Catalog=uHappening; Integrated Security=true";
			//SqlConnection conn = new SqlConnection(connectionString);
			//SqlCommand cmd = new SqlCommand();
			//cmd.Connection = conn;
			//cmd.CommandText = "INSERT INTO dbo.[Events] (EventName, EventType, Location, StartTime, EndTime, EventDescription) VALUES (" + eventName.Text
			//    +", " + eventType.Items[eventType.SelectedIndex] +", " + eventlocation.Text +", " + DateTime.UtcNow + ", " + DateTime.UtcNow + ", " + eventDescription + ")" ;
			//cmd.ExecuteNonQuery();
		}

		//private async void IsPrivateClicked(object sender, EventArgs e)
		//{
		//    string[] input = new string[] { "Yes", "No" };
		//    string value = await DisplayActionSheet("Private Event ? ", "cancel", "", input);
		//    if (value != null && value == "Yes")
		//    {
		//        isPrivate.Text = "Yes";
		//    }
		//    else if (value != null && value == "No")
		//    {
		//        isPrivate.Text = "No";
		//    }
		//}
	}
}
