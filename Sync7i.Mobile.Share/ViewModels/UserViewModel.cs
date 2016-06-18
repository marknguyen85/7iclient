using MvvmCross.Core.ViewModels;
using Sync7i.Mobile.BusinessLogics;

namespace Sync7i.Mobile.Share
{
	public class UserViewModel : BaseViewModel<UserModel>
    {
		public override void Start()
		{
			base.Start();
			if (!string.IsNullOrWhiteSpace(UserBiz.Instance.UGToken))
			{
				Model = new UserModel();
				if (UserBiz.Instance.User != null)
				{
					Model.UserName = UserBiz.Instance.User.UserId;
					Model.Password = UserBiz.Instance.User.Password;

				}
				else {
					Model.UserName = "admin@7i.com.vn";
					Model.Password = "abcde12345-";
				}
			}
			else
				ShowViewModel<LoginViewModel>();
		}

		public void Logout()
		{
			UserBiz.Instance.ResetToken();
			ShowViewModel<LoginViewModel>();
		}

		private IMvxCommand _logoutCommand;
		public IMvxCommand LogoutCommand
		{
			get
			{
				return (_logoutCommand = _logoutCommand ?? new MvxCommand(Logout));
			}
		}

	}
}