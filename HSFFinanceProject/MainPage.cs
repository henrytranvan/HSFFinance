using System;
using Xamarin.Forms;

namespace HSFFinanceProject
{
	public class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			Master = new MenuPage ();
			Detail = new DetailPage ();
		}
	}
}

