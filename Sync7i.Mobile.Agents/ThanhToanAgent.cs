using Sync7i.Mobile.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sync7i.Mobile.Agents
{
    public partial class ThanhToanAgent : AgentBase<ThanhToanAgent>
    {
        private const string ThanhToanController = "ThanhToan";
        //api/ThanhToan/GetPagedOlder
        private readonly string ResourceGetPagedOlder = string.Format(ResourceBaseGetPagedOlder, ThanhToanController);
        public async Task<ObservableCollection<NhapHang>> GetPagedOlder(PagedPara id, string ugToken)
        {
            RequestBase request = new RequestBase(ResourceGetPagedOlder, ugToken, id);
            var banle = await ExecuteAsync<ObservableCollection<NhapHang>>(request);

            return banle;
        }
    }
}
