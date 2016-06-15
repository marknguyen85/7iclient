using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Agents;

namespace Sync7i.Mobile.BusinessLogics
{
    public interface IBanSiTTBiz
	{
        Task<ObservableCollection<BanSiTT>> GetList(ListFullPara id);
	}

    public class BanSiTTBiz : BaseBiz<BanSiTTBiz>, IBanSiTTBiz
	{
        public async Task<ObservableCollection<BanSiTT>> GetList(ListFullPara id)
        {
            return await AgentRepository.Instance.BanSiTT.GetList(id, UserBiz.Instance.UGToken);
        }
    }
}

