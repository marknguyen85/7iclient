
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;

namespace Sync7i.Mobile.Share
{
    public partial class LocationStoreViewModel : BaseViewModel<LocationStoreModel>
	{
        public LocationStoreViewModel()
        {
        }
		public override async void OnCreate ()
		{
			base.OnCreate ();

            IsBusy = true;
            try
            {
                 var lst= await LocationStoreBiz.Instance.GetAll();
                 ListModel = LocationStoreModel.Map(lst);
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("Location Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
		}
    }
}

