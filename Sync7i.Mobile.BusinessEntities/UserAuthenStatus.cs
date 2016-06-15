using Sync7i.Mobile.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sync7i.Mobile.BusinessEntities
{
    public class UserAuthenStatus
    {
        public bool Successeded { get; set; }
        public string UGToken { get; set; }
        public string Message { get; set; }
        public List<ComLocationStore> ListStores { get; set; }
    }
}
