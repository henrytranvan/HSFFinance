using System;
using Xamarin.Forms;

using HSFFinance.Models;
using HSFFinance.ViewModels;
using HSFFinance.Views;

using Connectivity.Plugin;

using System.Collections.Generic;
using System.Linq;

namespace HSFFinanceProject
{
	public class PFDictionaryPage : ContentPage
	{

		PFDictionaryView list;
		SearchBar searchbar;
	 
		public PFDictionaryPage ()
		{

			NavigationPage.SetTitleIcon (this, "hsflogo.png");

			var isConnected = CrossConnectivity.Current.IsConnected;

			if (isConnected) {
				
			 
				WebView webView = new WebView {
					Source = new UrlWebViewSource {
						Url = "http://finance.hsfdev.bienalto.com/jargon-buster",
					},
					VerticalOptions = LayoutOptions.FillAndExpand
				};

				//this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

				// Build the page.
				this.Content = new StackLayout {
					Children = {
						webView
					}
				};

			} else {
				
				Title = "PF Dictionary page";

				list = new PFDictionaryView ();

				searchbar = new SearchBar () {
					Placeholder = "Search",
					HeightRequest = 50,
					BindingContext = Color.Black,
					BackgroundColor = Color.Silver,
				};

				BackgroundColor = Color.White;

				searchbar.TextChanged += (sender, e) => list.FilterTitle (searchbar.Text);
				searchbar.SearchButtonPressed += (sender, e) => {
					list.FilterTitle(searchbar.Text);
				};
					

				var stack = new StackLayout () {
					Orientation = StackOrientation.Vertical,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					Spacing = 0, 
					Children = {
						searchbar,
						list,
					}
				};


				var scrollview = new ScrollView {
					Content =  stack,

				};

				Content = scrollview;

			}

		}
	}
}
