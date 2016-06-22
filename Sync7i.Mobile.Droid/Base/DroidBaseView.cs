using Sync7i.Mobile.Share;
using Android.App;
using Android.Content;
using MvvmCross.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Core.ViewModels;
using Android.Views;
using Android.Content.Res;
using Android.OS;
using Android.Support.V7.Widget;
using Sync7i.Mobile.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using Sync7i.Mobile.Share.Interfaces;
using Java.Lang;

namespace Sync7i.Mobile.Droid
{
	public abstract class DroidBaseView<T> : MvxAppCompatActivity<T>, IUXHandler where T: BaseViewModel
	{
		
		public void DisplayAlert(string title, string message, AlertButton close)
		{
			var dialog = Mvx.Resolve<IDialogService>();
			dialog.Alert(message, title, close.ToString());
		}

		public void AppExit()
		{
			JavaSystem.Exit(0);
		}

		private ProgressDialog _progressDialog = null;
		public void ShowWaiting(string title, string message)
		{
			if (_progressDialog == null)
			{
				_progressDialog = new ProgressDialog(this, Android.Resource.Style.ThemeDialog) { Indeterminate = false };
				_progressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
				_progressDialog.SetCancelable(false);
			}

			_progressDialog.SetTitle(title);
			_progressDialog.SetMessage(message);

			_progressDialog.Show();
		}
		public void HideWaiting()
		{
			if (_progressDialog != null)
			{
				_progressDialog.Hide();
			}
		}

		public new T ViewModel {
			get { 
				var temp = base.ViewModel as T;
				return temp; 
			}
			set { 
				base.ViewModel = value;
				if (value != null)
				{
					value.UXHandler = this;
				}
			}
		}

		protected override void OnViewModelSet()
		{
			base.OnViewModelSet();

			var temp = base.ViewModel as T;
			if (temp != null)
			{
				temp.UXHandler = this;
			}

			var viewWithCycle = ViewModel as IViewLifeCycle;

			if (viewWithCycle != null)
			{
				viewWithCycle.OnCreate();
			}

		}
	}

	public abstract class BaseHostedView<T> : MvxCachingFragmentCompatActivity<T>, IUXHandler where T : BaseViewModel
	{
		public void DisplayAlert(string title, string message, AlertButton close)
		{
			var dialog = Mvx.Resolve<IDialogService>();
			dialog.Alert(message, title, close.ToString());
		}

		public void AppExit()
		{
			JavaSystem.Exit(0);
		}

		private ProgressDialog _progressDialog = null;
		public void ShowWaiting(string title, string message)
		{
			if (_progressDialog == null)
			{
				_progressDialog = new ProgressDialog(this, Android.Resource.Style.ThemeDialog) { Indeterminate = false };
				_progressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
				_progressDialog.SetCancelable(false);
			}

			_progressDialog.SetTitle(title);
			_progressDialog.SetMessage(message);

			_progressDialog.Show();
		}
		public void HideWaiting()
		{
			if (_progressDialog != null)
			{
				_progressDialog.Hide();
			}
		}

		public new T ViewModel
		{
			get
			{
				var temp = base.ViewModel as T;
				return temp;
			}
			set
			{
				base.ViewModel = value;
				if (value != null)
				{
					value.UXHandler = this;
				}
			}
		}
	}

	public abstract class BaseNestedView<T> : MvxFragment, IUXHandler where T : BaseViewModel, IMvxViewModel
	{
		protected Toolbar _toolbar;
		protected MvxActionBarDrawerToggle _drawerToggle;
		/// <summary>
		/// If true show the hamburger menu
		/// </summary>
		protected bool showHamburgerMenu = false;

		protected BaseNestedView()
		{
			RetainInstance = true;
		}

		public override void OnAttach(Context context)
		{
			if (ViewModel != null)
			{
				this.ViewModel.OnDetach();
			}
			base.OnAttach(context);
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var ignore = base.OnCreateView(inflater, container, savedInstanceState);

			var view = this.BindingInflate(FragmentId, null);
			_toolbar = view.FindViewById<Toolbar>(Resource.Id.toolbar);
			if (_toolbar != null)
			{
				//set title of 
				if (string.IsNullOrEmpty(FragmentName))
				{
					_toolbar.Title = FragmentName;
				}

				((MainActivity)Activity).SetSupportActionBar(_toolbar);
				if (showHamburgerMenu)
				{
					((MainActivity)Activity).SupportActionBar.SetDisplayHomeAsUpEnabled(true);

					_drawerToggle = new MvxActionBarDrawerToggle(
						Activity,                               // host Activity
						((MainActivity)Activity).DrawerLayout,  // DrawerLayout object
						_toolbar,                               // nav drawer icon to replace 'Up' caret
						Resource.String.drawer_open,            // "open drawer" description
						Resource.String.drawer_close            // "close drawer" description
					);

					_drawerToggle.DrawerOpened += (object sender, ActionBarDrawerEventArgs e) =>
					{
						if (Activity != null)
							((MainActivity)Activity).HideSoftKeyboard();
					};
					((MainActivity)Activity).DrawerLayout.AddDrawerListener(_drawerToggle);
				}
			}

			if (ViewModel != null)
			{
				this.ViewModel.OnCreate();

				var temp = this.ViewModel as T;
				if (temp != null)
				{
					temp.UXHandler = this;
				}

			}

			return view;
		}

		protected abstract int FragmentId { get; }

		protected abstract string FragmentName { get; }

		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (_toolbar != null && null != _drawerToggle)
			{
				_drawerToggle.OnConfigurationChanged(newConfig);
			}
		}

		public override void OnActivityCreated(Bundle savedInstanceState)
		{
			base.OnActivityCreated(savedInstanceState);
			if (_toolbar != null && null != _drawerToggle)
			{
				_drawerToggle.SyncState();
			}
		}

		public void DisplayAlert(string title, string message, AlertButton button)
		{
			var dialog = Mvx.Resolve<IDialogService>();
			dialog.Alert(message, title, button.ToString());
		}

		public void AppExit()
		{
			JavaSystem.Exit(0);
		}

		public new T ViewModel
		{
			get { return (T)base.ViewModel; }
			set { base.ViewModel = value; }
		}
	}
}

