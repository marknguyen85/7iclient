
using System.Windows.Input;
using Sync7i.Mobile.BusinessLogics;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public partial class OverviewViewModel : ReportListBaseViewModel<OverviewModel>
	{
		private List<OverViewItem> _listItem;

		public List<OverViewItem> ListItem
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
				ListItem = new List<OverViewItem>(CreateList(Model));
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

		IEnumerable<OverViewItem> CreateList(OverviewModel model)
		{
			var lst = new List<OverViewItem>();
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Bán lẻ", Model.BanLe.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Chi phí", Model.ChiPhi.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Công nợ", Model.CongNo.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Nhập hàng", Model.NhapHang.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Tạm ứng", Model.TamUng.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Thanh toán", Model.ThanhToan.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Thu khác", Model.ThuKhac.ToString()));
			lst.Add(new OverViewItem(this, MenuType.BanLe, "Tiền mặt", Model.TienMat.ToString()));

			return lst;
		}

		public void OverViewItemCommand(OverViewItem item)
		{
			if (item.Type == MenuType.BanLe)
			{
				ShowBanLe(item.Model);
			}
			else if (item.Type == MenuType.CongNo)
			{
				ShowCongNo(item.Model);
			}
			else if (item.Type == MenuType.NhapHang)
			{
				ShowNhapHang(item.Model);
			}
			else if (item.Type == MenuType.TamUng)
			{
				ShowTamUng(item.Model);
			}
			else if (item.Type == MenuType.ThanhToan)
			{
				ShowThanhToan(item.Model);
			}
			else if (item.Type == MenuType.ThuKhac)
			{
				ShowThuKhac(item.Model);
			}
			else if (item.Type == MenuType.ChiPhi)
			{
			}
			else if (item.Type == MenuType.TienMat)
			{
			}
		}

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
        private IMvxCommand banLeCommand;
        public IMvxCommand BanLeCommand
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

