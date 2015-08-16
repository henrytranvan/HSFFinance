using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using HSFFinance.ViewModels;
using HSFFinance.Models;


namespace HSFFinance.Views
{
	public class FooterView : ListView
	{
		List<FooterModel> footerModels;

		public FooterView ()
		{
			 
			footerModels = new FooterViewModel();

		

			var cell = new DataTemplate (typeof(FooterCell));
			cell.SetBinding (TextCell.TextProperty, "Title");

			ItemTemplate = cell;

			ItemsSource = footerModels;
			RowHeight = 30;
			BackgroundColor = Color.FromRgb (0, 50,75);
			HorizontalOptions = LayoutOptions.Fill;
			VerticalOptions = LayoutOptions.FillAndExpand;
			ItemSelected += (s, e) => {
				if (SelectedItem == null)
					return;
				var selected = (LatestThinkingModel)e.SelectedItem;
				SelectedItem = null;
				//Navigation.PushAsync (new CampusLocationPage (selected));
			};
						
	}
	}
}
