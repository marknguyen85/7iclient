
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
	public partial class MenuViewModel : BaseViewModel<UserModel>
	{
		private ICommand _menuSelectedCommand;

		public ICommand MenuSelectedCommand {
			get {
				return (_menuSelectedCommand = _menuSelectedCommand ?? new MvxCommand<MenuItem>((item) => {
					var a = item;
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
        private IMvxCommand _LogoutCommand;
        public IMvxCommand LogoutCommand
        {
            get
            {
                return (_LogoutCommand = _LogoutCommand ?? new MvxCommand(ShowPlan));
            }
        }
        
	}
}

