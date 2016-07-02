
using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.BusinessLogics;
using Sync7i.Mobile.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UG.Mobile.Framework;
using MvvmCross.Platform;

namespace Sync7i.Mobile.Share
{
    public enum AlertButton
    {
        OK=1,
        Yes = 2,
        Close=3
    }
    public interface IUXHandler
    {
        void DisplayAlert(string title, string message, AlertButton button);
		void AppExit();
    }

	public interface IViewLifeCycle {
		void OnCreate ();
		void OnDetach();
	}
	public abstract class BaseViewModel : MvxViewModel, IViewLifeCycle
	{
		protected readonly INetworkService _NService;
		protected readonly IPlatform _platForm;
		public BaseViewModel()
		{
			_NService = Mvx.Resolve<INetworkService>();
			_platForm = Mvx.Resolve<IPlatform>();
		}

		private bool _SidebarShown;

		public bool SidebarShown {
			get {
				return _SidebarShown;
			}
			set {
				SetProperty (ref _SidebarShown, value);
			}
		}

        private ICommand _BackMenuCommand;
        public ICommand BackMenuCommand
        {
            get
            {
				return (_BackMenuCommand = _BackMenuCommand ?? new MvxCommand(() => {
					SidebarShown = true;
					//Show menu
					ShowViewModel<MenuViewModel>();
				}));
//				return (_BackMenuCommand = _BackMenuCommand ?? new MvxCommand(ShowMenuViewModel));
            }
        }

		private IMvxCommand _checkNetworkCommand;
		public IMvxCommand CheckNetworkCommand
		{
			get
			{
				return (_checkNetworkCommand = _checkNetworkCommand ?? new MvxCommand(() =>
				{
					IsNotConnected = !_NService.IsNetworkAvailable();
				}));
			}
		}

		private void ShowMenuViewModel()
        {
			SidebarShown = true;
            //Show menu
            ShowViewModel<MenuViewModel>();
        }
        public IUXHandler UXHandler { get; set; }
        private bool _IsBusy;

        public bool IsBusy
        {
            get
            {
                return _IsBusy;
            }
            set
            {
				SetProperty(ref _IsBusy, value);
            }
        }

		private bool _IsNotConnected;

		public bool IsNotConnected
		{
			get
			{
				return _IsNotConnected;
			}
			set
			{
				SetProperty(ref _IsNotConnected, value);
			}
		}
        #region IViewLifeCycle implementation
        public virtual void OnCreate()
        {
			if (!_NService.IsNetworkAvailable())
			{
				IsNotConnected = true;
				return;
			}
			else
			{
				IsNotConnected = false;
			}

		}

		public void OnDetach ()
		{
			
		}
        #endregion
    }
    public abstract class BaseViewModel<T> : BaseViewModel where T : BaseModel
    {
		
		public List<int> CurrentListStore { get { return UserBiz.Instance.ListStores; } }

        private T _model;

        public T Model
        {
            get
            {
                return _model;
            }
            set
            {
				SetProperty(ref _model, value);
				RaisePropertyChanged(() => Model);
            }
        }
        private ObservableCollection<T> _listModel;

        public ObservableCollection<T> ListModel
        {
            get
            {
                return _listModel;
            }
            set
            {
				SetProperty(ref _listModel, value);
				RaisePropertyChanged(() => ListModel);
            }
        }
	}
    public enum DateType
    {
        [EnumDescription("Ngày")]
        Daily = 0,
        [EnumDescription("Tuần")]
        Weekly = 1,
        [EnumDescription("Tháng")]
        Monthly = 2,
        [EnumDescription("Thùy chọn")]
        Option = 3,
        [EnumDescription("Home")]
        Home = 4,
    }
    public class AppPara
    {
        public static DateType CurrentDateType { get; set; }
        public static int CurrentNav { get; set; }
        public static DateTime StartDate { get; set; }
        public static DateTime EndDate { get; set; }
    }
    public abstract class ReportBaseViewModel<T> : BaseViewModel<T> where T : BaseModel
    {
        public ListFullPara CurrentPara()
        {
            return GetPara(CurrentListStore, AppPara.CurrentDateType, AppPara.CurrentNav);
        }
        //public DateType CurrentDateType { get { return AppPara.CurrentDateType; } }
        public DateType Daily { get { return DateType.Daily; } }
        public DateType Weekly { get { return DateType.Weekly; } }
        public DateType Monthly { get { return DateType.Monthly; } }
        public DateType Option { get { return DateType.Option; } }
        public DateType Home { get { return DateType.Home; } }

        private string _NavTitle;

        public string NavTitle
        {
            get
            {
                return _NavTitle;
            }
            set
            {
                SetProperty(ref _NavTitle, value);
            }
        }
        private string GetNavTitle (){

            if (AppPara.StartDate.Date == AppPara.EndDate.Date)
                return AppPara.StartDate.ToString("dd-MM-yy");
            return string.Format("{0}->{1}", AppPara.StartDate.ToString("dd-MM"), AppPara.EndDate.ToString("dd-MM")); 
        }

       
        private ICommand _FilterCommand;
        public ICommand FilterCommand
        {
            get
            {
                return (_FilterCommand = _FilterCommand ?? new MvxCommand<DateType>((item) => ActionFilter(item)));
            }
        }
        private void ActionFilter(DateType item)
        {
            if (item == DateType.Home)
                ShowViewModel<OverviewViewModel>();
            else
            {
                AppPara.CurrentDateType = item;
                ShowViewModel(this.GetType());
            }
        }
        private ICommand _BackTimeCommand;
        public ICommand BackTimeCommand
        {
            get
            {
                return (_BackTimeCommand = _BackTimeCommand ?? new MvxCommand(ActionBackTime));
            }
        }
        private void ActionBackTime()
        {
            AppPara.CurrentNav = AppPara.CurrentNav - 1;
            ShowViewModel(this.GetType());
        }
        private ICommand _NextTimeCommand;
        public ICommand NextTimeCommand
        {
            get
            {
                return (_NextTimeCommand = _NextTimeCommand ?? new MvxCommand(ActionNextTime));
            }
        }
        private void ActionNextTime()
        {
            AppPara.CurrentNav = AppPara.CurrentNav + 1;
            ShowViewModel(this.GetType());
        }
        protected PagedPara GetPagedPara(long currrentOnID, int count)
        {
            PagedPara id = new PagedPara();
            var current = CurrentPara();
            id.ListStore = current.ListStore;
            id.StartDate = current.StartDate;
            id.EndDate = current.EndDate;
            id.CurrentOnID = currrentOnID;
            id.StartIndex = count;

            return id;
        }
        private ListFullPara GetPara(List<int> lstStoreID, DateType dateType, int dateNav)
        {
			//TODO: fake date 
			var cDate = new DateTime(2015, 11, 01);
            ListFullPara para = new ListFullPara();
            para.ListStore = lstStoreID;
            switch (dateType)
            {
                case DateType.Daily:
					AppPara.StartDate = cDate.Date.AddDays(dateNav);
                    AppPara.EndDate = cDate.Date.AddDays(dateNav);
                    break;
                case DateType.Weekly:
                    AppPara.StartDate = Week.CurrentWeek.WeekStart.AddDays(dateNav * 7);
                    AppPara.EndDate = Week.CurrentWeek.WeekFinish.AddDays(dateNav * 7);
                    break;
                case DateType.Monthly:
                    AppPara.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01).AddMonths(dateNav);
                    AppPara.EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).AddMonths(dateNav);
                    break;
                default:
                    AppPara.StartDate = DateTime.Now.Date.AddDays(dateNav);
                    AppPara.EndDate = DateTime.Now.Date.AddDays(dateNav);
                    break;
            }
            para.StartDate = AppPara.StartDate;
            para.EndDate = AppPara.EndDate;
            NavTitle = GetNavTitle();

            
            return para;
        }
       
    }
    public abstract class ReportListBaseViewModel<T> : ReportBaseViewModel<T> where T : BaseModel
    {
		private OverviewModel _OverviewModel;
        public OverviewModel OverviewModel
        {
            get
            {
                return _OverviewModel;
            }
            set
            {
                SetProperty(ref _OverviewModel, value);
            }
        }
        public void Init(string Parameter)
        {
            if (!string.IsNullOrWhiteSpace(Parameter))
                OverviewModel = JsonConvert.DeserializeObject<OverviewModel>(Parameter);
        }

        public override async void OnCreate()
        {
            base.OnCreate();
			if (IsNotConnected)
			{
				return;
			}
			if (OverviewModel == null)
            {
                IsBusy = true;
                try
                {
                    var para = CurrentPara();
                    OverviewModel = OverviewModel.Map(await OverViewBiz.Instance.Get(para));
                }
                catch (Exception ex)
                {
                    UXHandler.DisplayAlert("Overview Error", ex.Message, AlertButton.OK);
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }
    }
}

