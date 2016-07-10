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
    [Register("sync7i.mobile.droid.fragments.GiamSatFragment")]
    public class GiamSatFragment : BaseNestedView<GiamSatViewModel>
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
				return Resource.Layout.fragment_giamsat;
            }
        }

		protected override string FragmentName
		{
			get
			{
				return "";
			}
		}
		protected override MvxFragment Fragment
		{
			get
			{
				return this;
			}
		}

	}
}