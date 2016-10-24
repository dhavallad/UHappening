using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UHappening
{
	public partial class Startup : ContentPage
	{
		public Startup()
		{
			List<ContentPage> pages = new List<ContentPage>(0);
			Color[] colors = { Color.Red, Color.Green, Color.Blue };
			foreach (Color c in colors)
			{
				pages.Add(new ContentPage
				{
					Content = new StackLayout
					{
						Children = {
				new Label { Text = c.ToString () },
				new BoxView {
					Color = c,
					VerticalOptions = LayoutOptions.FillAndExpand
				}
			}
					}
				});
			}


			InitializeComponent();
		}
	}
}
