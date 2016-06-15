using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Agents;

namespace Sync7i.Mobile.BusinessLogics
{
    public interface IOverViewBiz
	{
        Task<OverView> Get(ListFullPara id);
	}

    public class OverViewBiz : BaseBiz<OverViewBiz>, IOverViewBiz
	{
        public async Task<OverView> Get(ListFullPara id)
        {
            return await AgentRepository.Instance.OverView.Get(id, UserBiz.Instance.UGToken);
        }
    }
}

