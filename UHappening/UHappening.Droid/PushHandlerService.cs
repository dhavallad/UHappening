using System;
using Android.App;
using Android.Content;
using Android.Gms.Gcm;
using Android.Gms.Gcm.Iid;

namespace UHappening.Droid
{
	[Service(Exported = false)]
	public class PushHandlerService : IntentService
	{


		static object locker = new object();
		//public RegistrationIntentService() : base("RegistrationIntentService") { }

		public PushHandlerService()
		{
		}

		protected override void OnHandleIntent(Intent intent)
		{

			try
			{
				//to avoid multiple registration intents occurring simultaneously
				lock (locker)
				{
					//step 3.4
					var instanceID = InstanceID.GetInstance(this);
					var token = instanceID.GetToken("896086570609", GoogleCloudMessaging.InstanceIdScope, null);
					SendRegistrationToAppServer(token);
					Subscribe(token);
				}
			}
			catch
			{
				return;
			}
			//throw new NotImplementedException();
		}

		void SendRegistrationToAppServer(string token)
		{
			// skipped this step.
		}

		void Subscribe(string token)
		{
			var pubSub = GcmPubSub.GetInstance(this);
			pubSub.Subscribe(token, "/topics/global", null);
		}

	}
}

