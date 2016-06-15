using Sync7i.Mobile.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sync7i.Mobile.Agents
{
    public partial class LocationStoreAgent : AgentBase<LocationStoreAgent>
    {
        private const string LocationStoreController = "LocationStore";
        //api/LocationStore/Get
        private readonly string ResourceGetALL = string.Format("api/{0}/GetAll", LocationStoreController);
        public async Task<ObservableCollection<ComLocationStore>> GetAll(string ugToken)
        {
            RequestBase request = new RequestBase(ResourceGetALL, ugToken);
            var banle = await ExecuteAsync<ObservableCollection<ComLocationStore>>(request);

            return banle;
        }
    }
}
