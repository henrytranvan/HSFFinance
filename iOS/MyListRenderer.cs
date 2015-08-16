using System;
using MonoTouch;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using HSFFinance.Views;

[assembly: ExportRenderer (typeof(MenuListView), typeof (HSFFinanceProject.MyListRenderer))]
namespace HSFFinanceProject
{
	public class MyListRenderer : ListViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged (e);
			var nativeTableView = (UITableView)Control;
			nativeTableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
	
		}
	}
}

