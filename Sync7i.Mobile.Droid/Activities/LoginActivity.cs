using Android.App;
using Android.Content.PM;
using Android.OS;
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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_login);
        }

    }
}

