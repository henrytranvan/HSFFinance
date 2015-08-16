using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HSFFinance.Models
{

	public class PFDictionary
	{
		public string Title { get; set; }

		public string Definition { get; set; }

		public string TitleSort
		{
			get 
			{
				if (string.IsNullOrWhiteSpace(Title) || Title.Length == 0)
					return "?";

				return Title[0].ToString().ToUpper();
			}
		}

	}
	
}