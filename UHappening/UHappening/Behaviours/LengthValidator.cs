using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UHappening
{
	public class LengthValidator : Behavior<Entry>
	{
		public static readonly BindableProperty LengthProperty = BindableProperty.Create("Length", typeof(int), typeof(LengthValidator), 0);

		public int Length
		{
			get { return (int)GetValue(LengthProperty); }
			set { SetValue(LengthProperty, value); }
		}


		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged += bindable_TextChanged;
		}

		private void bindable_TextChanged(object sender, TextChangedEventArgs e)
		{
			//if (MaxLength != null && MaxLength.HasValue)
			//((Entry)sender).TextColor = e.NewTextValue.Length == Length ? Color.Default : Color.Red;
			if (e.NewTextValue.Length >= Length)
			{
				((Entry)sender).Text = e.NewTextValue.Substring(0, Length);
				((Entry)sender).TextColor = Color.Default;
			}
			else
			{
				((Entry)sender).TextColor = Color.Red;
			}

			//	((Entry)sender).Text = e.NewTextValue.Substring(0, Length);
		}

		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.TextChanged -= bindable_TextChanged;

		}
	}
}
