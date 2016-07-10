using System;
using System.Threading.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Sync7i.Mobile.Droid.Activities;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.Droid.BindingContext;
using Sync7i.Mobile.Share;

namespace Sync7i.Mobile.Droid.Fragments
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.navigation_frame)]
    [Register("sync7i.mobile.droid.fragments.MenuFragment")]
    public class MenuFragment : BaseNestedView<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;
        private IMenuItem _previousMenuItem;

		protected override int FragmentId
		{
			get
			{
				return Resource.Layout.fragment_navigation;
			}
		}

		protected override string FragmentName
		{
			get
			{
				return "Menu";
			}
		}

		protected override MvxFragment Fragment
		{
			get
			{
				return this;
			}
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_navigation, null);

            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);
            _navigationView.Menu.FindItem(Resource.Id.nav_home).SetChecked(true);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item != _previousMenuItem)
            {
                _previousMenuItem?.SetChecked(false);
            }
            
            item.SetCheckable(true);
            item.SetChecked(true);

            _previousMenuItem = item;

            Navigate (item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            ((MainActivity)Activity).DrawerLayout.CloseDrawers ();

            // add a small delay to prevent any UI issues
            await Task.Delay (TimeSpan.FromMilliseconds (250));

            switch (itemId) 
            {
                case Resource.Id.nav_home:
                    ViewModel.OverviewCommand.Execute();
                    break;
				case Resource.Id.nav_giamsat:
					ViewModel.GiamSatCommand.Execute();
					break;
				case Resource.Id.nav_cuahang:
					ViewModel.GiamSatCommand.Execute();
					break;
				case Resource.Id.nav_congno:
					ViewModel.CongNoCommand.Execute();
					break;
				case Resource.Id.nav_kehoach:
					ViewModel.PlanCommand.Execute();
					break;
				case Resource.Id.nav_settings:
					ViewModel.SettingsCommand.Execute();
					break;
            }
        }
    }
}
