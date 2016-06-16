using Sync7i.Mobile.Share;
using Android.App;
using System;
using Android.Content;
using MvvmCross.Platform.Core;
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

namespace Sync7i.Mobile.Droid
{
	public abstract class DroidBaseView<T> : MvxAppCompatActivity<T> where T: BaseViewModel
	{
		public void DisplayAlert(string title, string message, AlertButton close)
		{
			var dispatcher = Mvx.Resolve<IMvxMainThreadDispatcher>();
			dispatcher.RequestMainThreadAction(() => {
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.SetTitle(title);
				builder.SetMessage(message);
				builder.SetNegativeButton(close.ToString(), (EventHandler<DialogClickEventArgs>)null);
				builder.Show();
			});
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
			}
		}

	}

	public abstract class BaseHostedView<T> : MvxCachingFragmentCompatActivity<T> where T : BaseViewModel
	{
		public void DisplayAlert(string title, string message, AlertButton close)
		{
			var dispatcher = Mvx.Resolve<IMvxMainThreadDispatcher>();
			dispatcher.RequestMainThreadAction(() =>
			{
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.SetTitle(title);
				builder.SetMessage(message);
				builder.SetNegativeButton(close.ToString(), (EventHandler<DialogClickEventArgs>)null);
				builder.Show();
			});
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
			}
		}
	}

	public abstract class BaseNestedView : MvxFragment
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
				((BaseViewModel)this.ViewModel).OnDetach();
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
					_drawerToggle.DrawerOpened += (object sender, ActionBarDrawerEventArgs e) => {
						if (Activity != null)
							((MainActivity)Activity).HideSoftKeyboard();
					};
					((MainActivity)Activity).DrawerLayout.AddDrawerListener(_drawerToggle);
				}
			}

			if (ViewModel != null)
			{
				((BaseViewModel)this.ViewModel).OnCreate();
			}

			return view;
		}

		protected abstract int FragmentId { get; }

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
	}

	public abstract class BaseNestedView<T> : BaseNestedView where T : BaseViewModel, IMvxViewModel
	{
		public void DisplayAlert(string title, string message, AlertButton close)
		{
			var dispatcher = Mvx.Resolve<IMvxMainThreadDispatcher>();
			dispatcher.RequestMainThreadAction(() =>
			{
				AlertDialog.Builder builder = new AlertDialog.Builder(this.Activity);
				builder.SetTitle(title);
				builder.SetMessage(message);
				builder.SetNegativeButton(close.ToString(), (EventHandler<DialogClickEventArgs>)null);
				builder.Show();
			});
		}

		private ProgressDialog _progressDialog = null;
		public void ShowWaiting(string title, string message)
		{
			if (_progressDialog == null)
			{
				_progressDialog = new ProgressDialog(this.Activity, Android.Resource.Style.ThemeDialog) { Indeterminate = false };
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
			get { return (T)base.ViewModel; }
			set { base.ViewModel = value; }
		}
	}
}

