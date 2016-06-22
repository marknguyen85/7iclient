using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Sync7i.Mobile.Share;

namespace Sync7i.Mobile.Droid.Activities
{
	[Activity(
        Label = "Đăng nhập",
        Theme = "@style/AppTheme.Login",
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
        Name = "sync7i.mobile.droid.activities.LoginActivity"
    )]			
	public class LoginActivity : DroidBaseView<LoginViewModel>
    {
		static int TIME_INTERVAL = 2; // # milliseconds, desired time passed between two back presses.
		DateTime mBackPressed = DateTime.MinValue;

		protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_login);
        }

		/// <summary>
		/// prevent back button
		/// </summary>
		/// <returns>The back pressed.</returns>
		public override void OnBackPressed()
		{
			if ((DateTime.Now - mBackPressed).TotalSeconds < TIME_INTERVAL)
			{
				base.AppExit();
				//Process.KillProcess(Process.MyPid());
				return;
			}
			else {
				Toast.MakeText(ApplicationContext, "Nhấn 2 lần để thoát ứng dụng", ToastLength.Short).Show();
			}
			mBackPressed = DateTime.Now;
		}

	}
}

