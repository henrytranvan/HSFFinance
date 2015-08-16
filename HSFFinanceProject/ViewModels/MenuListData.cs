using System;
using Xamarin.Forms;
using System.Collections.Generic;
using HSFFinance.Models;
using HSFFinanceProject;

namespace HSFFinance.ViewModels
{

	public class MenuListData : List<MenuItemModel>
	{
		public MenuListData ()
		{
			
			this.Add (new MenuItemModel () { 
				Title = "Home".ToUpper(), 
				TargetType = typeof(HomePageDetail)
			});

			this.Add (new MenuItemModel () { 
				Title = "Latest Thinking".ToUpper(), 
				TargetType = typeof(LatestThingkingPage)
			});
					
			this.Add (new MenuItemModel () { 
				Title = "PF Dictionary".ToUpper(), 

				TargetType = typeof(PFDictionaryPage)
			});

			this.Add (new MenuItemModel () {
				Title = "Sector News".ToUpper(),
				TargetType = typeof(CoreIndustryPage)
			});

			this.Add (new MenuItemModel () { 
				Title = "Contact Us".ToUpper(), 
				TargetType = typeof(ContactUsPage)
			});

		}
	}
}