using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Agents;

namespace Sync7i.Mobile.BusinessLogics
{
    public interface IThuKhacBiz
	{
        Task<ThuKhac> Get(IDPara id);
        Task<ObservableCollection<ThuKhac>> GetPagedOlder(PagedPara id);
        Task<ObservableCollection<ThuKhac>> GetLastest(LastestPagedPara id);
        Task<int> GetCountLastest(LastestPagedPara id);
	}

    public class ThuKhacBiz : BaseBiz<ThuKhacBiz>, IThuKhacBiz
	{
        public async Task<ThuKhac> Get(IDPara id)
        {
            return await AgentRepository.Instance.ThuKhac.Get(id, UserBiz.Instance.UGToken);
        }
        public async Task<ObservableCollection<ThuKhac>> GetPagedOlder(PagedPara id)
        {
            return await AgentRepository.Instance.ThuKhac.GetPagedOlder(id, UserBiz.Instance.UGToken);
        }
        public async Task<ObservableCollection<ThuKhac>> GetLastest(LastestPagedPara id)
        {
            return await AgentRepository.Instance.ThuKhac.GetLastest(id, UserBiz.Instance.UGToken);
        }
        public async Task<int> GetCountLastest(LastestPagedPara id)
        {
            return await AgentRepository.Instance.ThuKhac.GetCountLastest(id, UserBiz.Instance.UGToken);
        }
    }
}

