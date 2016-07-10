using Android.Runtime;
using Android.Views;
using Android.OS;
using MvvmCross.Droid.Shared.Attributes;
using Sync7i.Mobile.Share;
using MvvmCross.Droid.Support.V4;

namespace Sync7i.Mobile.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("sync7i.mobile.droid.fragments.CongNoFragment")]
    public class CongNoFragment : BaseNestedView<CongNoViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.showHamburgerMenu = true;
            var view = base.OnCreateView(inflater, container, savedInstanceState);
			return view;
        }

		protected override string FragmentName
		{
			get
			{
				return "Công nợ";
			}
		}
        protected override int FragmentId
        {
            get
            {
				return Resource.Layout.fragment_congno;
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