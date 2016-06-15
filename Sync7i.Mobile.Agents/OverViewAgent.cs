using Sync7i.Mobile.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sync7i.Mobile.Agents
{
    public partial class OverViewAgent : AgentBase<OverViewAgent>
    {

        private const string OverViewController = "OverView";
        //api/OverView/Get
        private readonly string ResourceGet = string.Format("api/{0}/Get", OverViewController);
        public async Task<OverView> Get(ListFullPara id, string ugToken)
        {
            RequestBase request = new RequestBase(ResourceGet, ugToken, id);
            var banle = await ExecuteAsync<OverView>(request);

            return banle;
        }
    }
}
