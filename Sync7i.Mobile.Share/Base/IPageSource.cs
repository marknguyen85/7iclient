
using System.Windows.Input;
using System.Collections.ObjectModel;
using Sync7i.Mobile.BusinessEntities;
using System.Threading.Tasks;
using Sync7i.Mobile.BusinessLogics;

namespace Sync7i.Mobile.Share
{
    public interface IPageSource<T> where T : PagedBaseModel
    {
        Task<ObservableCollection<T>> GetPagedOlder(long currrentOnID,int count);
        Task<ObservableCollection<T>> GetPagedOlder(PagedPara id);
    }
}

