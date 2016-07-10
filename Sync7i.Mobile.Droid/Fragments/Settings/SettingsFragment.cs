using Android.Runtime;
using Android.Views;
using Android.OS;
using MvvmCross.Droid.Shared.Attributes;
using Sync7i.Mobile.Share;
using System;
using MvvmCross.Droid.Support.V4;

namespace Sync7i.Mobile.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("sync7i.mobile.droid.fragments.SettingsFragment")]
    public class SettingsFragment : BaseNestedView<SettingsViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.showHamburgerMenu = true;
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        protected override int FragmentId
        {
            get
            {
				return Resource.Layout.fragment_settings;
            }
        }

		protected override string FragmentName
		{
			get
			{
				return "Cấu hình";
			}
		}

		protected override MvxFragment Fragment
		{
			get
			{
				return this;
			}
		}

		/// <Docs>The options menu in which you place your items.</Docs>
		/// <returns>To be added.</returns>
		/// <summary>
		/// This is the menu for the Toolbar/Action Bar to use
		/// </summary>
		/// <param name="menu">Menu.</param>
		public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
		{
			//inflater.Inflate(Resource.Menu.home, menu);
			base.OnCreateOptionsMenu(menu, inflater);
		}

	}
}