
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;

namespace Sync7i.Mobile.Share
{
    public partial class TamUngViewModel : ReportListBaseViewModel<TamUngModel>, IPageSource<TamUngModel>
	{
        public TamUngViewModel()
        {
        }
		public override void OnCreate ()
		{
			base.OnCreate ();
		}

        public async Task<ObservableCollection<TamUngModel>> GetPagedOlder(PagedPara id)
        {
            return TamUngModel.Map(await TamUngBiz.Instance.GetPagedOlder(id));
        }
        public async Task<ObservableCollection<TamUngModel>> GetPagedOlder(long currrentOnID, int count)
        {
            IsBusy = true;
            var id = GetPagedPara(currrentOnID, count);
            try
            {
                var lst = TamUngModel.Map(await TamUngBiz.Instance.GetPagedOlder(id));
                return lst;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("TamUng Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
            return new ObservableCollection<TamUngModel>();
        }
    }
}

