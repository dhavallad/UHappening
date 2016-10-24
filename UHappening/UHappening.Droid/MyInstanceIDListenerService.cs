﻿using Android.Gms.Gcm.Iid;
using Android.Content;
using Android.App;

namespace UHappening.Droid
{
	[Service(Exported = false), IntentFilter(new[] { "com.google.android.gms.iid.InstanceID" })]
	public class MyInstanceIDListenerService : InstanceIDListenerService
	{
		private const string TAG = "MyInstanceIDLS";

		public override void OnTokenRefresh()
		{
			var intent = new Intent(this, typeof(RegistrationIntentService));
			StartService(intent);
		}
	}
}

