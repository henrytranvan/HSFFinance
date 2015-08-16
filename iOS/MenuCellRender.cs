using System;
using HSFFinance.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(MenuCell), typeof(HSFFinanceProject.MenuCellRender))]

namespace HSFFinanceProject
{
	public class MenuCellRender : ViewCellRenderer
	{
		
		public override UIKit.UITableViewCell GetCell (Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			
			var cell = base.GetCell (item, reusableCell, tv);

			cell.BackgroundColor = UIColor.Black;
			cell.TextLabel.TextColor = UIColor.White;



			cell.SelectedBackgroundView = new UIView {
				BackgroundColor = UIColor.FromRGB(119,129,137),
			};


			return cell;


		}
	}
}

