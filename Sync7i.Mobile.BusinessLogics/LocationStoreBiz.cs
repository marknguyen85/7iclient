using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Agents;

namespace Sync7i.Mobile.BusinessLogics
{
    public interface ILocationStoreBiz
	{
        Task<ObservableCollection<ComLocationStore>> GetAll();
	}

    public class LocationStoreBiz : BaseBiz<LocationStoreBiz>, ILocationStoreBiz
	{
        public async Task<ObservableCollection<ComLocationStore>> GetAll()
        {
            return await AgentRepository.Instance.LocationStore.GetAll(UserBiz.Instance.UGToken);
        }
    }
}

