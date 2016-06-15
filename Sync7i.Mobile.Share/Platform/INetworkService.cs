using System;

namespace Sync7i.Mobile.Share
{
	public interface INetworkService
	{
		bool TryReach(string uri);

		bool IsNetworkAvailable();

        string MacAddress();
	}
}

