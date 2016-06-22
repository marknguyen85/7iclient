using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using Sync7i.Mobile.Droid.Activities;
using Sync7i.Mobile.Share;

namespace Sync7i.Mobile.Droid.Fragments
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
	[Register("sync7i.mobile.droid.fragments.UserFragment")]
    public class UserFragment : BaseNestedView<UserViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.showHamburgerMenu = true;
			var view = base.OnCreateView(inflater, container, savedInstanceState);

			((MainActivity)Activity).DrawerLayout.CloseDrawers();

			return view;
		}

		protected override int FragmentId
		{
			get
			{
				return Resource.Layout.fragment_user;
			}
		}

		protected override string FragmentName
		{
			get
			{
				return "";
			}
		}
	}
}
