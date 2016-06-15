using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
    public class PagedBaseModel : BaseModel
    {
        public long OnID { get; set; }
    }
    public abstract class BaseModel : MvxNotifyPropertyChanged
	{
        
	}
}

