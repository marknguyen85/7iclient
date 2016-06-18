using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Sync7i.Mobile.Share;


namespace Sync7i.Mobile.Droid.Activities
{
    [Activity( 
        Label = "Trang chủ",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "sync7i.mobile.droid.activities.MainActivity"
    )]
    public class MainActivity : BaseHostedView<MainViewModel>
    {
        public DrawerLayout DrawerLayout;

		static int TIME_INTERVAL = 2; // # milliseconds, desired time passed between two back presses.
		DateTime mBackPressed = DateTime.MinValue;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            DrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            if (bundle == null)
                ViewModel.ShowMenu();
                    
        }

		/// <summary>
		/// prevent back button
		/// </summary>
		/// <returns>The back pressed.</returns>
		public override void OnBackPressed()
		{
			if ((DateTime.Now - mBackPressed).TotalSeconds < TIME_INTERVAL)
			{
				Process.KillProcess(Process.MyPid());
				return;
			}
			else { 
				if (DrawerLayout != null && DrawerLayout.IsDrawerOpen(GravityCompat.Start))
					DrawerLayout.CloseDrawers();
				else
					Toast.MakeText(this.ApplicationContext, "Nhấn 2 lần để thoát ứng dụng", ToastLength.Short).Show(); 
			}
			mBackPressed = DateTime.Now;
		}

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    DrawerLayout.OpenDrawer(GravityCompat.Start);
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void ShowBackButton()
        {
            //TODO Tell the toggle to set the indicator off
            //this.DrawerToggle.DrawerIndicatorEnabled = false;

            //Block the menu slide gesture
            DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeLockedClosed);
        }

        private void ShowHamburguerMenu()
        {
            //TODO set toggle indicator as enabled 
            //this.DrawerToggle.DrawerIndicatorEnabled = true;

            //Unlock the menu sliding gesture
            DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeUnlocked);
        }

		public void HideSoftKeyboard()
		{
			if (CurrentFocus == null) return;

			InputMethodManager inputMethodManager = (InputMethodManager)GetSystemService(InputMethodService);
			inputMethodManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, 0);

			CurrentFocus.ClearFocus();
		}
    }
}