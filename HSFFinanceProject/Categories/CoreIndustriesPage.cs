using System;
using Xamarin.Forms;

namespace HSFFinanceProject
{
	public class CoreIndustriesPage : ContentPage
	{
		public CoreIndustriesPage ()
		{
			NavigationPage.SetTitleIcon (this, "hsflogo.png");

			WebView webView = new WebView
			{
				Source = new UrlWebViewSource
				{
					Url = "http://finance.hsfdev.bienalto.com/finance/core-industry/mobileapps",
				},

				VerticalOptions = LayoutOptions.FillAndExpand
			};
		

			//this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{
					webView
				}
				};


		}
	}
}


