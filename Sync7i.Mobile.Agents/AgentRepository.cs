#region

using System;
using System.Collections.Generic;

#endregion

namespace Sync7i.Mobile.Agents
{
    public class AgentRepository
    {
        private static object _lock = new object();
        private static AgentRepository service;
        public static AgentRepository Instance
        {
            get
            {
                if (service == null)
                {
                    lock (_lock)
                    {
                        service = new AgentRepository();
                        return service;
                    }
                }
                return service;
            }
        }
        public UsersAgent Users { get { return UsersAgent.Instance; } }
        public BanLeAgent BanLe { get { return BanLeAgent.Instance; } }
        public BanSiTTAgent BanSiTT { get { return  BanSiTTAgent.Instance; } }
        public ChiPhiAgent ChiPhi { get { return  ChiPhiAgent.Instance; } }
        public LocationStoreAgent LocationStore { get { return LocationStoreAgent.Instance; } }
        public NhapHangAgent NhapHang { get { return  NhapHangAgent.Instance; } }
        public ThanhToanAgent ThanhToan { get { return ThanhToanAgent.Instance; } }
        public OverViewAgent OverView { get { return  OverViewAgent.Instance; } }
        public SanPhamAgent SanPham { get { return  SanPhamAgent.Instance; } }
        public TamUngAgent TamUng { get { return  TamUngAgent.Instance; } }
        public ThuKhacAgent ThuKhac { get { return  ThuKhacAgent.Instance; } }
    }
}

