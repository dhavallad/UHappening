using System;
using Xamarin.Forms;
namespace UHappening
{
	public class RequiredField : Behavior<Entry>
	{
		static readonly BindablePropertyKey HasValuePropertyKey =
		BindableProperty.CreateReadOnly("HasValue", typeof(bool), typeof(RequiredField), false);
		public static readonly BindableProperty HasValueProperty = HasValuePropertyKey.BindableProperty;

		public bool HasValue
		{
			get { return (bool)base.GetValue(HasValueProperty); }
			private set { base.SetValue(HasValuePropertyKey, value); }
		}
		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged += HandleTextChanged;
			base.OnAttachedTo(bindable);
		}
		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.TextChanged -= HandleTextChanged;
			base.OnDetachingFrom(bindable);
		}
		void HandleTextChanged(object sender, TextChangedEventArgs e)
		{
			HasValue = !string.IsNullOrEmpty(e.NewTextValue);
		}
	}
}
