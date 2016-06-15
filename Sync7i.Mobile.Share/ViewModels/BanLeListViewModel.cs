
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public partial class BanLeListViewModel : ReportListBaseViewModel<BanLeModel>, IPageSource<BanLeModel>
	{
        public BanLeListViewModel()
        {
        }
		public override void OnCreate ()
		{
			base.OnCreate ();
		}
        public void ShowBanLeChiTiet(BanLeModel item)
        {
            ShowViewModel<BanLeCTViewModel>(item);
        }
        private ICommand banLeChiTietCommand;
        public ICommand BanLeChiTietCommand
        {
            get
            {
                return (banLeChiTietCommand = banLeChiTietCommand ?? new MvxCommand<BanLeModel>((item)=>ShowBanLeChiTiet(item)));
            }
        }
        public async Task<ObservableCollection<BanLeModel>> GetPagedOlder(PagedPara id)
        {
            IsBusy = true;
            var lst = BanLeModel.Map(await BanLeBiz.Instance.GetPagedOlder(id));
            IsBusy = false;
            return lst;
        }
        public async Task<ObservableCollection<BanLeModel>> GetPagedOlder(long currrentOnID, int count)
        {
            IsBusy = true;
            var id = GetPagedPara(currrentOnID, count);
            try
            {
                var lst = BanLeModel.Map(await BanLeBiz.Instance.GetPagedOlder(id));
                return lst;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("BanLe Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
            return new ObservableCollection<BanLeModel>();
        }       
    }
}

