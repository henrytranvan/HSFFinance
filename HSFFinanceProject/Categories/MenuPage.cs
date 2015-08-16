using System;
using Xamarin.Forms;
using System.Collections.Generic;
using HSFFinance.Views;

using HSFFinance.Models;
using HSFFinance.ViewModels;


namespace HSFFinanceProject
{
	public class MenuPage : ContentPage
	{
		public ListView Menu { get; set; }

		public MenuPage ()
		{
			Icon = "settings.png";
			Title = "menu"; // The Title property must be set.
			Menu = new MenuListView ();

			var menuLabel = new ContentView {
				Padding = new Thickness (10, 36, 0, 5),
				Content = new Label {
					TextColor = Color.FromHex ("AAAAAA"),
					Text = "MENU", 
				}
			};

			//this.Padding = new Thickness(10, Device.OnPlatform(50, 0, 0), 10, 5);

			var layout = new StackLayout { 
				Spacing = 0, 
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			layout.Children.Add (menuLabel);
			layout.Children.Add (Menu);

			Content = layout;
		}
	}
}