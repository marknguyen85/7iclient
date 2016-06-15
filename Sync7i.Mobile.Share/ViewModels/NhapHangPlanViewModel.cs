
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;
using System;
using System.Linq;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public partial class NhapHangPlanViewModel : BaseViewModel<NhapHangPlanModel>
	{
        public NhapHangPlanViewModel()
        {
        }

		public void Init(){
			
		}
		public override async void OnCreate ()
		{
			base.OnCreate ();
            IsBusy = true;
            ListFullPara para = new ListFullPara();
            para.ListStore = CurrentListStore;
            try
            {
                ListModel = new ObservableCollection<NhapHangPlanModel>();
                var lst = await NhapHangBiz.Instance.GetPlan(para);

                var cn = from k in lst where (k.NgayTT - DateTime.Now.Date).Days < 0 select k;

                if (cn.Count() > 0)
                {
                    ListModel.Add(new NhapHangPlanModel()
                    {
                        NgayTT = DateTime.Now.Date.AddDays(-1),
                        TongTien = cn.Sum(x => x.ConNo),
                        ListNhapHang = NhapHangModel.Map(new ObservableCollection<NhapHang>(cn))
                    });
                }

                for(int i=0;i<15;i++)
                {
                    cn = from k in lst where (k.NgayTT - DateTime.Now.Date).Days == i select k;
                    if (cn.Count() > 0)
                    {
                        ListModel.Add(new NhapHangPlanModel()
                        {
                            NgayTT = DateTime.Now.Date.AddDays(i),
                            TongTien = cn.Sum(x => x.ConNo),
                            ListNhapHang = NhapHangModel.Map(new ObservableCollection<NhapHang>(cn))
                        });
                    }
                }

                cn = from k in lst where (k.NgayTT - DateTime.Now.Date).Days > 14 select k;

                if (cn.Count() > 0)
                {
                    ListModel.Add(new NhapHangPlanModel()
                    {
                        NgayTT = DateTime.Now.Date.AddDays(15),
                        TongTien = cn.Sum(x => x.ConNo),
                        ListNhapHang = NhapHangModel.Map(new ObservableCollection<NhapHang>(cn))
                    });
                }
            }
            catch (Exception ex)
            {
                UXHandler.DisplayAlert("NhapHang Plan Error", ex.Message, AlertButton.OK);
            }
            finally
            {
                IsBusy = false;
            }
		}

        public void ShowChiTiet(NhapHangModel model)
        {
            model.ViewType = EnumViewModelNhapHangType.Plan;
            ShowViewModel<NhapHangCTViewModel>(model);
        }
        private ICommand chiTietCommand;
        public ICommand ChiTietCommand
        {
            get
            {
                return (chiTietCommand = chiTietCommand ?? new MvxCommand<NhapHangModel>((item)=>ShowChiTiet(item)));
            }
        }
    }
}

