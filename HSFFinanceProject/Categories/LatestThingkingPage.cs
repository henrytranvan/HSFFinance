using System;
using Xamarin.Forms;

using HSFFinance.Models;
using HSFFinance.ViewModels;
using HSFFinance.Views;

namespace HSFFinanceProject
{
	public class LatestThingkingPage : ContentPage

	{
		
		public LatestThingkingPage ()
		{

			NavigationPage.SetTitleIcon (this, "hsflogo.png");

			WebView webView = new WebView
			{
				Source = new UrlWebViewSource
				{
					Url = "http://finance.hsfdev.bienalto.com/finance/latest-thinking",
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