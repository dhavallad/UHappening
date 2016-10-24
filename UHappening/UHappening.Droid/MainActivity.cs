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
using Android.Util;
using Android.Support.V7.App;

namespace UHappening.Droid
{
	[Activity(Label = "UHappening", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{

		//const int PLAY_SERVICES_RESOLUTION_REQUEST = 9000;
		//const string TAG = "MainActivity";

		//BroadcastReceiver mRegistrationBroadcastReceiver;
		//ProgressBar mRegistrationProgressBar;
		//TextView mInformationTextView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);

			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
			LoadApplication(new App());

			//	base.OnCreate(savedInstanceState);
			//	SetContentView(Resource.Layout.activity_main);

			//	mRegistrationProgressBar = FindViewById<ProgressBar>(Resource.Id.registrationProgressBar);
			//	mRegistrationBroadcastReceiver = new BroadcastReceiver();
			//	mRegistrationBroadcastReceiver.Receive += (sender, e) =>
			//	{

			//		mRegistrationProgressBar.Visibility = ViewStates.Gone;
			//		var sharedPreferences = PreferenceManager.GetDefaultSharedPreferences((Context)sender);
			//		var sentToken = sharedPreferences.GetBoolean(QuickstartPreferences.SENT_TOKEN_TO_SERVER, false);
			//		mInformationTextView.Text = sentToken ? GetString(Resource.String.gcm_send_message) : GetString(Resource.String.token_error_message);
			//	};
			//	mInformationTextView = FindViewById<TextView>(Resource.Id.informationTextView);

			//	if (CheckPlayServices())
			//	{
			//		var intent = new Intent(this, typeof(RegistrationIntentService));
			//		StartService(intent);
			//	}

			//}

			//protected override void OnResume()
			//{
			//	base.OnResume();
			//	LocalBroadcastManager.GetInstance(this).RegisterReceiver(mRegistrationBroadcastReceiver,
			//		new IntentFilter(QuickstartPreferences.REGISTRATION_COMPLETE));
			//}

			//protected override void OnPause()
			//{
			//	LocalBroadcastManager.GetInstance(this).UnregisterReceiver(mRegistrationBroadcastReceiver);
			//	base.OnPause();
			//}

			//bool CheckPlayServices()
			//{
			//	//int resultCode = GoogleApiAvailability.isGooglePlayServicesAvailable(this);
			//	//if (resultCode != ConnectionResult.Success)
			//	//{
			//	//	if (GoogleApiAvailability.IsUserRecoverableError(resultCode))
			//	//	{
			//	//		GoogleApiAvailability.GetErrorDialog(resultCode, this,
			//	//			PLAY_SERVICES_RESOLUTION_REQUEST).Show();
			//	//	}
			//	//	else {
			//	//		Log.Info(TAG, "This device is not supported.");
			//	//		Finish();
			//	//	}
			//	//	return false;
			//	//}
			//	return true;
			//}

			//class BroadcastReceiver : Android.Content.BroadcastReceiver
			//{
			//	public EventHandler<BroadcastEventArgs> Receive { get; set; }

			//	public override void OnReceive(Context context, Intent intent)
			//	{
			//		if (Receive != null)
			//			Receive(context, new BroadcastEventArgs(intent));
			//	}
			//}

			//class BroadcastEventArgs : EventArgs
			//{
			//	public Intent Intent { get; private set; }

			//	public BroadcastEventArgs(Intent intent)
			//	{
			//		Intent = intent;
			//	}
			//}
		}

	}
}