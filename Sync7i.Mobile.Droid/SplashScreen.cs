using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Sync7i.Mobile.Droid
{
	[Activity(
		MainLauncher = true
		, Theme = "@style/AppTheme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.splash_screen)
        {
        }
    }
}