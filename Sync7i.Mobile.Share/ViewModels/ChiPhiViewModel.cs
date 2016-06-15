
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;

namespace Sync7i.Mobile.Share
{
    public partial class ChiPhiViewModel : ReportListBaseViewModel<ChiPhiModel>, IPageSource<ChiPhiModel>
	{
        public ChiPhiViewModel()
        {
        }
		public override void OnCreate ()
		{
			base.OnCreate ();
		}

        public async Task<ObservableCollection<ChiPhiModel>> GetPagedOlder(PagedPara id)
        {
            return ChiPhiModel.Map(await ChiPhiBiz.Instance.GetPagedOlder(id));
        }

        public async Task<ObservableCollection<ChiPhiModel>> GetPagedOlder(long currrentOnID, int count)
        {
            IsBusy = true;
            var id = GetPagedPara(currrentOnID, count);
            try
            {
                var lst = ChiPhiModel.Map(await ChiPhiBiz.Instance.GetPagedOlder(id));
                return lst;
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("ChiPhi Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
            return new ObservableCollection<ChiPhiModel>();
        }
    }
}

