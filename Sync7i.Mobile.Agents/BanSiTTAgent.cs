using Sync7i.Mobile.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sync7i.Mobile.Agents
{
    public partial class BanSiTTAgent : AgentBase<BanSiTTAgent>
    {
        private const string BanSiTTController = "BanSiTT";
        //api/BanSiTT/GetList
        private readonly string ResourceGetList = string.Format("api/{0}/GetList", BanSiTTController);
        public async Task<ObservableCollection<BanSiTT>> GetList(ListFullPara id, string ugToken)
        {
            RequestBase request = new RequestBase(ResourceGetList, ugToken, id);
            var banle = await ExecuteAsync<ObservableCollection<BanSiTT>>(request);

            return banle;
        }
    }
}
