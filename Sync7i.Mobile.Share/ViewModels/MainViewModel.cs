﻿namespace Sync7i.Mobile.Share
{
	public class MainViewModel : BaseViewModel
    {
        public void ShowMenu()
        {
			ShowViewModel<SettingsViewModel>();
            ShowViewModel<MenuViewModel>();            
        }

        public void Init(object hint)
        {
            // Can perform Vm data retrival here based on any
            // data passed in the hint object

            // ShowViewModel<SomeViewModel>(new { derp: "herp", durr: "derrrrrr" });
            // public class SomeViewModel : MvxViewModel
            // {
            //     public void Init(string derp, string durr)
            //     {
            //     }
            // }
        }

        public override void Start()
        {
            //base.Start();
        }
    }
}