using System;
using MvvmCross.Core.ViewModels;

namespace Sync7i.Mobile.Share
{
	public class OverViewItem
	{
		public OverViewItem(OverviewViewModel parent, MenuType type, string text, string value)
		{
			Model = parent.Model;
			Type = type;
			Name = text;
			Value = value;
			ItemCommand = new MvxCommand(() => parent.OverViewItemCommand(this));
		}
		public string Name { get; set; }
		public string Value { get; set; }
		public MenuType Type { get; set; }
		public OverviewModel Model { get; set; }
		public OverviewViewModel Parent { get; set; }
		public IMvxCommand ItemCommand { get; set; }
	}

}

