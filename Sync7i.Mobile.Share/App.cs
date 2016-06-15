using System;
using MvvmCross.Core.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace Sync7i.Mobile.Share
{
    public class App : MvxApplication
    {
        public override void Initialize()
		{
			// Construct custom application start object
			Mvx.ConstructAndRegisterSingleton<IMvxAppStart, CustomAppStart>();

			// request a reference to the constructed appstart object 
			var appStart = Mvx.Resolve<IMvxAppStart>();

			// register the appstart object
			RegisterAppStart(appStart);
        }

        public class CustomAppStart : MvxNavigatingObject, IMvxAppStart
        {
            public void Start(object hint = null)
            {
				ShowViewModel<LoginViewModel>();
            }
        }
    }

	public interface IHostableView {
		bool Show(IMvxView view);

        bool TryGet(Type viewModelType, out IMvxView view);
    }

	public interface IHostableViewPresenter {
		void Register(Type type, IHostableView parentView);
	}
}