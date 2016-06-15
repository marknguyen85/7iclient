
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;

namespace Sync7i.Mobile.Share
{
    public partial class ThuKhacViewModel : ReportListBaseViewModel<ThuKhacModel>, IPageSource<ThuKhacModel>
	{
        public ThuKhacViewModel()
        {
        }
		public override void OnCreate ()
		{
			base.OnCreate ();
		}

        public async Task<ObservableCollection<ThuKhacModel>> GetPagedOlder(PagedPara id)
        {
            return ThuKhacModel.Map(await ThuKhacBiz.Instance.GetPagedOlder(id));
        }
     
        public async Task<ObservableCollection<ThuKhacModel>> GetPagedOlder(long currrentOnID, int count)
        {
            IsBusy = true;
            var id = GetPagedPara(currrentOnID, count);
            try
            {
                var lst = ThuKhacModel.Map(await ThuKhacBiz.Instance.GetPagedOlder(id));
                return lst;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("ThuKhac Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
            return new ObservableCollection<ThuKhacModel>();
        }
    }
}

