﻿using Android.Runtime;
using Android.Views;
using Android.OS;
using MvvmCross.Droid.Shared.Attributes;
using Sync7i.Mobile.Share;
using System;
using MvvmCross.Droid.Support.V4;

namespace Sync7i.Mobile.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("sync7i.mobile.droid.fragments.KeHoachFragment")]
    public class KeHoachFragment : BaseNestedView<NhapHangPlanViewModel>
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
				return Resource.Layout.fragment_kehoach;
            }
        }

		protected override string FragmentName
		{
			get
			{
				return "Kế hoạch";
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