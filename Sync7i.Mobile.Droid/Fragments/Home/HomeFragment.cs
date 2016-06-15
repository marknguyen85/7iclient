using Android.Runtime;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using Sync7i.Mobile.Share;

namespace Sync7i.Mobile.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("sync7i.mobile.droid.fragments.HomeFragment")]
	public class HomeFragment : BaseNestedView<OverviewViewModel>
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
                return Resource.Layout.fragment_home;
            }
        }
    }
}