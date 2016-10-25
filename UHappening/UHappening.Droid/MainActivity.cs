using System;

using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Gms.Common;
using Android.Preferences;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Gcm.Client;
using Android.Util;

namespace UHappening.Droid
{
	[Activity(Label = "UHappening", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		public static MainActivity instance;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			instance = this;
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);

			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
			RegisterWithGCM();
			LoadApplication(new App());

		}

		private void RegisterWithGCM()
		{
			// Check to ensure everything's set up right
			GcmClient.CheckDevice(this);
			GcmClient.CheckManifest(this);

			// Register for push notifications
			Log.Info("MainActivity", "Registering...");
			GcmClient.Register(this, Constant.SenderID);
			Log.Info("MainActivity", "Whoa! Registered......");
		}

	}
}