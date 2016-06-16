using System.Windows.Input;
using Sync7i.Mobile.BusinessLogics;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Common;
using UG.Mobile.Framework;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public class LoginViewModel : BaseViewModel<UserModel>
	{
		private readonly INetworkService _NService;
		private readonly IPlatform _platForm;
		public LoginViewModel (IPlatform platForm, INetworkService nservice)
		{
			_NService = nservice;
            _platForm = platForm;
		}

		public override void Start ()
		{
			base.Start ();
			if (string.IsNullOrWhiteSpace (UserBiz.Instance.UGToken)) {
				Model = new UserModel ();
				if (UserBiz.Instance.User != null) {
					Model.UserName = UserBiz.Instance.User.UserId;
					Model.Password = UserBiz.Instance.User.Password;

				} else {
					Model.UserName = "admin@7i.com.vn";
					Model.Password = "abcde12345-";
				}
			} else
				ShowHomePage ();
		}

		public void ShowHomePage ()
		{
			if (_platForm.OS == TargetPlatform.Android)
			{
				ShowViewModel<MainViewModel>();
				return;
			}
			ShowViewModel<OverviewViewModel>();
        }

		private ICommand accessCommand;

		public ICommand AccessCommand {
			get {
				return (accessCommand = accessCommand ?? new MvxCommand (ShowHomePage));
			}
		}

		public void CleanToken ()
		{
			UserBiz.Instance.ResetToken ();
		}

		private ICommand cleanTokenCommand;

		public ICommand CleanTokenCommand {
			get {
				return (cleanTokenCommand = cleanTokenCommand ?? new MvxCommand (CleanToken));
			}
		}

		private ICommand loginCommand;

		public ICommand LoginCommand {
			get { 
				return (loginCommand = loginCommand ?? new MvxCommand (DoLogin));
			}
		}

		private async void DoLogin ()
		{
			IsBusy = true;
			if (!_NService.IsNetworkAvailable ()) {
				UXHandler.DisplayAlert ("Network Error", "No network available!", AlertButton.OK);
				return;
			}
            
			try {//"7BxuB2XwNUtceKvhG1Y88Q=="
				var status = await UserBiz.Instance.Authen (new UserAuthen (Model.UserName, Model.Password, _NService.MacAddress (), Sync7iConstants.ExpireTimeSpanHours));

				if (status.Successeded) {
					//var lstMenu = await _commonBiz.GetMenu();
					//if (lstMenu.Where(x=>x.MenuType==MenuType.Monitoring).Count() > 0)
					//    ShowViewModel<ProjectMonitorViewModel>();
					ShowHomePage ();
				} else {
					UXHandler.DisplayAlert ("Login Error", "Login Not Successful!", AlertButton.OK);
				}
			} catch (UnknownException ex) {
				UXHandler.DisplayAlert ("Login Error", ex.Message, AlertButton.OK);
			} finally {
				IsBusy = false;
			}
		}
	}
}


