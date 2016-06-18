
using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using Sync7i.Mobile.BusinessLogics;

namespace Sync7i.Mobile.Share
{
	public partial class MenuViewModel : BaseViewModel<UserModel>
	{
		public MenuViewModel()
		{
			IsBusy = true;
			try
			{
				Model = new UserModel();
				if (UserBiz.Instance.User != null)
				{
					Model.UserName = UserBiz.Instance.User.UserId;
					Model.Password = UserBiz.Instance.User.Password;

				}
				else {
					Model.UserName = "Guest";
					Model.Password = "";
				}
			}
			catch (Exception ex)
			{
				UXHandler.DisplayAlert("Overview Error", ex.Message, AlertButton.OK);
			}
			finally
			{
				IsBusy = false;
			}
		}

		private IMvxCommand _userSelectedCommand;
		public IMvxCommand UserSelectedCommand {
			get {
				return (_userSelectedCommand = _userSelectedCommand ?? new MvxCommand(() => {
					ShowViewModel<UserViewModel>();
				}));
			}
		}

		public void ShowSettings()
		{
			ShowViewModel<SettingsViewModel>();
		}

		private IMvxCommand _SettingsCommand;
		public IMvxCommand SettingsCommand
		{
			get
			{
				return (_SettingsCommand = _SettingsCommand ?? new MvxCommand(ShowSettings));
			}
		}

		public void ShowOverview()
        {
            ShowViewModel<OverviewViewModel>();
        }

        private IMvxCommand _OverviewCommand;
        public IMvxCommand OverviewCommand
        {
            get
            {
                return (_OverviewCommand = _OverviewCommand ?? new MvxCommand(ShowOverview));
            }
        }

        public void ShowGiamSat()
        {
            ShowViewModel<GiamSatViewModel>();
        }
        private IMvxCommand _GiamSatCommand;
        public IMvxCommand GiamSatCommand
        {
            get
            {
                return (_GiamSatCommand = _GiamSatCommand ?? new MvxCommand(ShowGiamSat));
            }
        }
        public void ShowCuaHang()
        {
            ShowViewModel<LocationStoreViewModel>();
        }
        private IMvxCommand _CuaHangCommand;
        public IMvxCommand CuaHangCommand
        {
            get
            {
                return (_CuaHangCommand = _CuaHangCommand ?? new MvxCommand(ShowCuaHang));
            }
        }
        public void ShowCongNo()
        {
            ShowViewModel<NhapHangCNViewModel>();
        }
        private IMvxCommand _CongNoCommand;
        public IMvxCommand CongNoCommand
        {
            get
            {
                return (_CongNoCommand = _CongNoCommand ?? new MvxCommand(ShowCongNo));
            }
        }
        public void ShowPlan()
        {
            ShowViewModel<NhapHangPlanViewModel>();
        }
        private IMvxCommand _PlanCommand;
        public IMvxCommand PlanCommand
        {
            get
            {
                return (_PlanCommand = _PlanCommand ?? new MvxCommand(ShowPlan));
            }
        }
        public void ShowLogin()
        {
            ShowViewModel<LoginViewModel>();
        }
	}
}

