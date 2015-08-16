using System;
using System.Collections.Generic;
using HSFFinance.Models;

namespace HSFFinance.ViewModels
{
	public class FooterViewModel : List<FooterModel>
	{


		public FooterViewModel ()
		{
			var footermodel = new List<FooterModel> () {
				new FooterModel ("Submit feedback"),
				new FooterModel ("Privacy policy"),
				new FooterModel ("Legal and regulatory"),
				new FooterModel ("Disclaimer"),
			};

			this.AddRange (footermodel);

		}
	}
}

