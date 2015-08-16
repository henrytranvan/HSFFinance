using System;
using Xamarin.Forms;
using System.Collections.Generic;

using HSFFinance.ViewModels;
using HSFFinance.Models;

namespace HSFFinance.Views
{

	public class MenuListView : ListView
	{
		public MenuListView ()
		{
			List<MenuItemModel> data = new MenuListData ();

			ItemsSource = data;
			VerticalOptions = LayoutOptions.FillAndExpand;
	
			BackgroundColor = Color.FromRgb(119,129,137);
			RowHeight = 70;

			SelectedItem = null;

			//SeparatorVisibility = SeparatorVisibility.None;
		
	
			var cell = new DataTemplate (typeof(MenuCell));
		

			//cell.SetBinding (MenuCell.TextProperty, "Title");
			//cell.SetBinding (MenuCell.ImageSourceProperty, "IconSource");

			ItemTemplate = cell;


		}
	}
}