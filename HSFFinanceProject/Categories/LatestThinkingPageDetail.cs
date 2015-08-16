using System;
using Xamarin.Forms;
using HSFFinance.Models;
using HSFFinance.ViewModels;
using HSFFinance.Views;

namespace HSFFinanceProject
{
	public class LatestThinkingPageDetail : ContentPage
	{
		public LatestThinkingPageDetail (LatestThinkingModel latestThinking)
		{

			this.Title = latestThinking.Title;

			Label lbl = new Label ();
			lbl.Text = latestThinking.nid.ToString();
 

			var stack = new StackLayout () {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Spacing = 0, 
				Children = {
					lbl
				}
			};


			var scrollview = new ScrollView {
				Content =  stack,

			};


			Content = scrollview;


		}
	}
}