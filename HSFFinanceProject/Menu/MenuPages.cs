using System;
using Xamarin.Forms;
using System.Collections.Generic;
using HSFFinance.Views;

using HSFFinance.Models;
using HSFFinance.ViewModels;

namespace HSFFinanceProject
{
	public class MenuPages : ContentPage
	{
		public ListView Menu { get; set; }

		public MenuPages ()
		{
			
			Title = "menu"; // The Title property must be set.
			if (Device.OS == TargetPlatform.Android) {
				Icon = "hsficon.png";
			} else {
				Icon = "masterIcon.png";
			}

			Menu = new MenuListView ();
			/*
			var menuLabel = new ContentView {
				Padding = new Thickness (100, 36, 0, 5),
				Content = new Label {
					TextColor = Color.White,
					Text = "MENU", 
				}
			};

           */
			//BackgroundColor = Color.FromRgb (89,89,89);
			var layout = new StackLayout { 
				Spacing = 0, 
				//Padding = new Thickness (0, 100, 0, 0),
				VerticalOptions = LayoutOptions.FillAndExpand

			};
			layout.Children.Add (Menu);

			Content = layout;
		}
	}
}