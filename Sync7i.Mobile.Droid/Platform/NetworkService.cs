using System;
using Sync7i.Mobile.Share;
using Android.App;
using Android.Net;

namespace Sync7i.Mobile.Droid
{
    public class NetworkService : INetworkService
    {
        private ConnectivityManager connectivityManager
        {
            get
            {
                if (_connectivityManager == null)
                {
                    _connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Application.ConnectivityService);
                }
                return _connectivityManager;
            }
        }

        ConnectivityManager _connectivityManager;

		#region INetworkService implementation

		public bool TryReach (string uri)
		{
			throw new NotImplementedException ();
		}

        public string MacAddress()
        {
            return "12345";
        }

        public bool IsNetworkAvailable()
        {
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            return (activeConnection != null) && activeConnection.IsConnected;
        }

        #endregion

    }
}

