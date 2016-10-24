using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UHappening
{
	public partial class TabPage : TabbedPage
	{
		public TabPage()
		{
			InitializeComponent();
			ItemsSource = MonkeyDataModel.All;
		}
	}
}
