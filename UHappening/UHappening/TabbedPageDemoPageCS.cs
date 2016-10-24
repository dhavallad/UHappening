using System;
using Xamarin.Forms;

namespace UHappening
{
	public class TabbedPageDemoPageCS : TabbedPage
	{
		public TabbedPageDemoPageCS()
		{
			var booleanConverter = new NonNullToBooleanConverter();

			ItemTemplate = new DataTemplate(() =>
			{
				var nameLabel = new Label
				{
					FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
					FontAttributes = FontAttributes.Bold,
					HorizontalOptions = LayoutOptions.Center
				};
				nameLabel.SetBinding(Label.TextProperty, "Name");

				var image = new Image { WidthRequest = 200, HeightRequest = 200 };
				image.SetBinding(Image.SourceProperty, "PhotoUrl");

				var FirstNameLabel = new Label
				{
					FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
					FontAttributes = FontAttributes.Bold
				};
				FirstNameLabel.SetBinding(Label.TextProperty, "FirstName");

				var subFirstNameLabel = new Label
				{
					FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
					FontAttributes = FontAttributes.Bold
				};
				subFirstNameLabel.SetBinding(Label.TextProperty, "SubFirstName");

				var tribeLabel = new Label
				{
					FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
					FontAttributes = FontAttributes.Bold
				};
				tribeLabel.SetBinding(Label.TextProperty, "Gender");

				var genusLabel = new Label
				{
					FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
					FontAttributes = FontAttributes.Bold
				};
				genusLabel.SetBinding(Label.TextProperty, "AlbanyID");

				var subFirstNameStackLayout = new StackLayout
				{
					Orientation = StackOrientation.Horizontal,
					Children = {
						new Label { Text = "SubFirstName:", HorizontalOptions = LayoutOptions.FillAndExpand },
						subFirstNameLabel
					}
				};
				subFirstNameStackLayout.SetBinding(VisualElement.IsVisibleProperty, new Binding("SubFirstName", BindingMode.Default, booleanConverter));

				var tribeStackLayout = new StackLayout
				{
					Orientation = StackOrientation.Horizontal,
					Children = {
						new Label { Text = "Gender:", HorizontalOptions = LayoutOptions.FillAndExpand },
						tribeLabel
					}
				};
				tribeStackLayout.SetBinding(VisualElement.IsVisibleProperty, new Binding("Gender", BindingMode.Default, booleanConverter));

				var contentPage = new ContentPage
				{
					Icon = "monkeyicon.png",
					Content = new StackLayout
					{
						Padding = new Thickness(5, 25),
						Children = {
							nameLabel,
							image,
							new StackLayout {
								Padding = new Thickness (50, 10),
								Children = {
									new StackLayout {
										Orientation = StackOrientation.Horizontal,
										Children = {
											new Label { Text = "FirstName:", HorizontalOptions = LayoutOptions.FillAndExpand },
											FirstNameLabel
										}
									},
									subFirstNameStackLayout,
									tribeStackLayout,
									new StackLayout {
										Orientation = StackOrientation.Horizontal,
										Children = {
											new Label { Text = "AlbanyID:", HorizontalOptions = LayoutOptions.FillAndExpand },
											genusLabel
										}
									}
								}
							}

						}
					}
				};
				contentPage.SetBinding(TitleProperty, "Name");

				return contentPage;
			});

			ItemsSource = MonkeyDataModel.All;
		}
	}
}
