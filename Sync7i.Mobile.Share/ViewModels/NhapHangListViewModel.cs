
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public partial class NhapHangListViewModel : ReportListBaseViewModel<NhapHangModel>, IPageSource<NhapHangModel>
	{
        public NhapHangListViewModel()
        {
        }
		public override void OnCreate ()
		{
			base.OnCreate ();
		}

        public async Task<ObservableCollection<NhapHangModel>> GetPagedOlder(PagedPara id)
        {
            return NhapHangModel.Map(await NhapHangBiz.Instance.GetPagedOlder(id));
        }
       
        public async Task<ObservableCollection<NhapHangModel>> GetPagedOlder(long currrentOnID, int count)
        {
            IsBusy = true;
            var id = GetPagedPara(currrentOnID, count);
            try
            {
                var lst = NhapHangModel.Map(await NhapHangBiz.Instance.GetPagedOlder(id));
                return lst;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("NhapHang Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
            return new ObservableCollection<NhapHangModel>();
        }
        public void ShowChiTiet(NhapHangModel model)
        {
            model.ViewType = EnumViewModelNhapHangType.NhapHang;
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

