using System;
using Xamarin.Forms;
using System.Collections.Generic;
using HSFFinance.Models;
using HSFFinanceProject;

namespace HSFFinance.ViewModels
{

	public class CoreIndustriesViewModel : List<CoreIndustriesModel>
	{
		public CoreIndustriesViewModel ()
		{
			this.Add (new CoreIndustriesModel () { 
				Title = "Social Infrastructure".ToUpper(), 
				IconSource = "contacts.png", 
				TargetType = typeof(HomePageDetail)
			});

			this.Add (new CoreIndustriesModel () { 
				Title = "Roads".ToUpper(), 
				IconSource = "leads.png", 
				TargetType = typeof(LatestThingkingPage)
			});

			this.Add (new CoreIndustriesModel () { 
				Title = "Rails".ToUpper(), 
				IconSource = "accounts.png", 
				TargetType = typeof(PFDictionaryPage)
			});

			this.Add (new CoreIndustriesModel () {
				Title = "Ports & Airports".ToUpper(),
				IconSource = "opportunities.png",
				TargetType = typeof(SectorNewsPage)
			});

			this.Add (new CoreIndustriesModel () { 
				Title = "Power".ToUpper(), 
				IconSource = "contacts.png", 
				TargetType = typeof(ContactUsPage)
			});

			this.Add (new CoreIndustriesModel () { 
				Title = "Oil & Gas".ToUpper(), 
				IconSource = "contacts.png", 
				TargetType = typeof(ContactUsPage)
			});
			this.Add (new CoreIndustriesModel () { 
				Title = "Resources".ToUpper(), 
				IconSource = "contacts.png", 
				TargetType = typeof(ContactUsPage)
			});
		}
	}
}