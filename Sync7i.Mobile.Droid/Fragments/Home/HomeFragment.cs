using Android.Runtime;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using Sync7i.Mobile.Share;
using Android.Widget;
using MvvmCross.Droid.Support.V4;

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

		protected override string FragmentName
		{
			get
			{
				return "Tổng quan";
			}
		}

		protected override MvxFragment Fragment
		{
			get
			{
				return this;
			}
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			DateType dateType = DateType.Daily;
			switch (item.ItemId)
			{
				default:
				case Resource.Id.menu_daylyview:
					dateType = DateType.Daily;
					break;
				case Resource.Id.menu_weeklyview:
					dateType = DateType.Weekly;
					break;
				case Resource.Id.menu_monthlyview:
					dateType = DateType.Monthly;
					break;
				case Resource.Id.menu_optionview:
					dateType = DateType.Option;
					break;
				case Resource.Id.menu_homeview:
					dateType = DateType.Home;
					break;
			}

			if (ViewModel.FilterCommand.CanExecute(null))
				ViewModel.FilterCommand.Execute(dateType);
			return base.OnOptionsItemSelected(item);
		}

	}
}