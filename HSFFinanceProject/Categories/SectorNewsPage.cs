using System;
using Xamarin.Forms;

namespace HSFFinanceProject
{
	public class SectorNewsPage : ContentPage
	{
		public SectorNewsPage ()
		{
			Title = "SectorNewsPage";
			Content = new Label () {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "SectorNewsPage"
			};
		}
	}
}