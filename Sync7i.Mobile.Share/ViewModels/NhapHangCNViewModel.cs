
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;
using System.Linq;
using UG.Mobile.Framework;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public partial class NhapHangCNViewModel : BaseViewModel<NhapHangCNModel>
	{
        public NhapHangCNViewModel()
        {
        }
        private decimal _TongCongNo;

        public decimal TongCongNo
        {
            get
            {
                return _TongCongNo;
            }
            set
            {
                SetProperty(ref _TongCongNo, value);
            }
        }
		public override async void OnCreate ()
		{
			base.OnCreate ();
            IsBusy = true;
            ListFullPara para = new ListFullPara();
            para.ListStore = CurrentListStore;
            try
            {
                ListModel = new ObservableCollection<NhapHangCNModel>();
                var lst = await NhapHangBiz.Instance.GetCongNo(para);
                var cn = from k in lst where k.TrangThai != (int)EnumTrangThaiCongNo.KyGui select k;
                ListModel.Add(new NhapHangCNModel()
                {
                    Title = "Công nợ: ",
                    TongTien = cn.Sum(x => x.ConNo),
                    ListNhapHang = NhapHangModel.Map(new ObservableCollection<NhapHang>(cn))
                });

                var kygui = from k in lst where k.TrangThai == (int)EnumTrangThaiCongNo.KyGui select k;
                ListModel.Add(new NhapHangCNModel()
                {
                    Title = "Ký gửi: ",
                    TongTien = kygui.Sum(x=>x.ConNo),
                    ListNhapHang = NhapHangModel.Map(new ObservableCollection<NhapHang>(kygui))
                });
                TongCongNo = ListModel[0].TongTien + ListModel[1].TongTien;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("NhapHang CongNo Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
		}

        public void ShowChiTiet(NhapHangModel model)
        {
            model.ViewType = EnumViewModelNhapHangType.CongNo;
            ShowViewModel<NhapHangCTViewModel>(model);
        }
        private ICommand chiTietCommand;
        public ICommand ChiTietCommand
        {
            get
            {
                return (chiTietCommand = chiTietCommand ?? new MvxCommand<NhapHangModel>((item)=>ShowChiTiet(item)));
            }
        }
    }
}

