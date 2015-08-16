using System;
using Xamarin.Forms;
using Connectivity.Plugin;
using HSFFinance.Models;

namespace HSFFinanceProject

{

	public class HomePage : MasterDetailPage
	{
		MenuPages menuPages;

		public HomePage()
		{	

			menuPages = new MenuPages ();

			menuPages.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItemModel);
			 	
			Master = menuPages;

			var navigationPage = new NavigationPage (new HomePageDetail ()){};

			navigationPage.BarBackgroundColor = Color.White;

			Detail = navigationPage;

		}

		void NavigateTo (MenuItemModel menu)
		{
			if (menu == null)
				return;

			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			var navigationPage = new NavigationPage (displayPage);
			navigationPage.BarBackgroundColor = Color.White;

			navigationPage.BarTextColor = Color.FromRgb(1,112,126);
			Detail = navigationPage;
				
			menuPages.Menu.SelectedItem = null;
			IsPresented = false;
		 }


		}


}

