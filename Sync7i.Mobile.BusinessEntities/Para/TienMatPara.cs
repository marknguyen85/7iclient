using System;
using System.Collections.Generic;
using System.Linq;

namespace Sync7i.Mobile.BusinessEntities
{
    public class TienMatPara : BaseInput
    {
        public int StoreID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
