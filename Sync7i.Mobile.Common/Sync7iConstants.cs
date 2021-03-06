
namespace Sync7i.Mobile.Common
{
    public enum TargetPlatform
    {
        Other,
        iOS,
        Android,
        WinPhone
    }
	public static class Sync7iConstants
	{
        //public const string BaseURL = "http://localhost:1732/";
        //public const string BaseURL = "http://s.7i.com.vn/";
        public const string BaseURL = "http://sm.coles.vn:88/";
        public static readonly bool IsMock = false;
        public static readonly int PageSize= 15;
        public static readonly int ExpireTimeSpanHours = 720;
        public const string PushNotificationId = "9f262516-f1c4-4050-91de-0be72c173c8a";
	}
}