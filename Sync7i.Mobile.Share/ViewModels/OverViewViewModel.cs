
using System.Windows.Input;
using Sync7i.Mobile.BusinessLogics;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace Sync7i.Mobile.Share
{
	public class OverViewItem { 
		public string Name { get; set; }
		public decimal Value { get; set; }
	}
    public partial class OverviewViewModel : ReportBaseViewModel<OverviewModel>
	{
		private ObservableCollection<OverViewItem> _listItem;

		public ObservableCollection<OverViewItem> ListItem
		{
			get
			{
				return _listItem;
			}
			set
			{
				SetProperty(ref _listItem, value);
				RaisePropertyChanged(() => ListItem);
			}
		}

		public override async void OnCreate ()
		{
			base.OnCreate ();
            IsBusy = true;
            try
            {
                var para = CurrentPara();
                Model = OverviewModel.Map(await OverViewBiz.Instance.Get(para));
				ListItem.Add(new OverViewItem
				{
					Name = "Bán lẻ",
					Value = Model.BanLe
				});
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
        private const string ParameterKey = "Parameter";
        private bool ShowViewModelOverview<TViewModel>(OverviewModel item) where TViewModel : IMvxViewModel
        {
            var text = JsonConvert.SerializeObject(item);
            return ShowViewModel<TViewModel>(new Dictionary<string, string>()
            {
                {ParameterKey, text}
            });
        }
        public void ShowBanLe(OverviewModel item)
        {
            ShowViewModelOverview<BanLeListViewModel>(item);
        }
        private ICommand banLeCommand;
        public ICommand BanLeCommand
        {
            get
            {
                return (banLeCommand = banLeCommand ?? new MvxCommand<OverviewModel>((item)=>ShowBanLe(item)));
            }
        }

        public void ShowThanhToan(OverviewModel item)
        {
            ShowViewModelOverview<ThanhToanViewModel>(item);
        }
        private ICommand thanhToanCommand;
        public ICommand ThanhToanCommand
        {
            get
            {
                return (thanhToanCommand = thanhToanCommand ?? new MvxCommand<OverviewModel>((item) => ShowThanhToan(item)));
            }
        }
        public void ShowChiPhi(OverviewModel item)
        {
            ShowViewModelOverview<ChiPhiViewModel>(item);
        }
        private ICommand chiPhiCommand;
        public ICommand ChiPhiCommand
        {
            get
            {
                return (chiPhiCommand = chiPhiCommand ?? new MvxCommand<OverviewModel>((item)=>ShowChiPhi(item)));
            }
        }
        public void ShowCongNo(OverviewModel item)
        {
            ShowViewModelOverview<CongNoViewModel>(item);
        }
        private ICommand congNoCommand;
        public ICommand CongNoCommand
        {
            get
            {
                return (congNoCommand = congNoCommand ?? new MvxCommand<OverviewModel>((item)=>ShowCongNo(item)));
            }
        }
        public void ShowNhapHang(OverviewModel item)
        {
            ShowViewModelOverview<NhapHangListViewModel>(item);
        }
        private ICommand nhapHangCommand;
        public ICommand NhapHangCommand
        {
            get
            {
                return (nhapHangCommand = nhapHangCommand ?? new MvxCommand<OverviewModel>((item)=>ShowNhapHang(item)));
            }
        }
        public void ShowTamUng(OverviewModel item)
        {
            ShowViewModelOverview<TamUngViewModel>(item);
        }
        private ICommand tamUngCommand;
        public ICommand TamUngCommand
        {
            get
            {
                return (tamUngCommand = tamUngCommand ?? new MvxCommand<OverviewModel>((item) => ShowTamUng(item)));
            }
        }
        public void ShowThuKhac(OverviewModel item)
        {
            ShowViewModelOverview<ThuKhacViewModel>(item);
        }
        private ICommand thuKhacCommand;
        public ICommand ThuKhacCommand
        {
            get
            {
                return (thuKhacCommand = thuKhacCommand ?? new MvxCommand<OverviewModel>((item) => ShowThuKhac(item)));
            }
        }
	}
}

