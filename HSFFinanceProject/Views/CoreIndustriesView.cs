using System;
using Xamarin.Forms;
using System.Collections.Generic;

using HSFFinance.ViewModels;
using HSFFinance.Models;

namespace HSFFinance.Views
{

	public class CoreIndustriesView : ListView
	{
		public CoreIndustriesView ()
		{
			List<CoreIndustriesModel> data = new CoreIndustriesViewModel ();

			ItemsSource = data;
			VerticalOptions = LayoutOptions.FillAndExpand;
 
			BackgroundColor = Color.White;
			var cell = new DataTemplate (typeof(CoreIndusteriesCell));
			cell.SetBinding (CoreIndusteriesCell.TextProperty, "Title");
			cell.SetBinding (CoreIndusteriesCell.ImageSourceProperty, "IconSource");

			ItemTemplate = cell;
		}
	}
}