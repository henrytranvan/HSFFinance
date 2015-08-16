using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

using HSFFinance.ViewModels;
using HSFFinance.Models;


namespace HSFFinance.Views
{
	public class PFDictionaryView : ListView
	{

		public PFDictionaresViewModel viewModel;

		public PFDictionaryView ()
		{
			viewModel = new PFDictionaresViewModel();
			ItemsSource = viewModel.PFDictionariesGrouped;
			IsGroupingEnabled = true;
			GroupDisplayBinding = new Binding("Key");
			GroupShortNameBinding = new Binding("Key");

			if(Device.OS != TargetPlatform.WinPhone)
				GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell));
			
			 var cell = new DataTemplate(typeof(PFDictCell));

			  
			 ItemTemplate = cell;
			 //SeparatorVisibility = SeparatorVisibility.None;
			 RowHeight = 60;
			 ItemTapped += (sender, args) =>
			 {
				var pfdic = args.Item as  PFDictionary;
				if (pfdic == null)
					return;

				//Navigation.PushAsync(new DetailsPage(pfdic));
				// Reset the selected item
				 SelectedItem = null;
			};
		}


		public void FilterTitle (string filter)
		{
			//this.BeginRefresh ();

			if (string.IsNullOrWhiteSpace (filter)) {
				this.ItemsSource = viewModel.PFDictionariesGrouped;
			} else {
				this.ItemsSource = viewModel.PFDictionariesGrouped
					.Where(o => o.Any(p => p.Title.ToLower().Contains(filter.ToLower())));
			}

			//this.EndRefresh ();
		}
			
	}
}