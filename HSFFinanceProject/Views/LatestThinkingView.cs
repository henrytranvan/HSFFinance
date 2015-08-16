using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using HSFFinance.ViewModels;
using HSFFinance.Models;
using System.Threading.Tasks;
using HSFFinanceProject;

namespace HSFFinance.Views
{
	public class LatestThinkingView : ListView
	{
		List<LatestThinkingModel> ltkModels;

		public LatestThinkingView ()
		{
			 
			ltkModels = new LatestThinkingViewModel();

		
			 
			BackgroundColor = Color.White;

			var cell = new DataTemplate (typeof(LatestThinkingCell));

			ItemsSource = ltkModels;

			ItemTemplate = cell;

			RowHeight = 80;

			ItemSelected += (s, e) => {
				if (SelectedItem == null)
					return;
				var selected = (LatestThinkingModel)e.SelectedItem;
				SelectedItem = null;
				Navigation.PushAsync (new LatestThinkingPageDetail (selected));
			};



				
		}
			
	}
}