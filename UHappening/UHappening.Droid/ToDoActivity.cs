using System;
using Gcm.Client;

namespace UHappening.Droid
{
	public class ToDoActivity
	{
		// Create a new instance field for this activity.
		static ToDoActivity instance = new ToDoActivity();

		// Return the current activity instance.
		public static ToDoActivity CurrentActivity
		{
			get
			{
				return instance;
			}
		}
		// Return the Mobile Services client.
		public MobileServiceClient CurrentClient
		{
			get
			{
				return client;
			}
		}

		public class MobileServiceClient
		{
		}

	}
}
