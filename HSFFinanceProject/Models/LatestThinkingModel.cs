using System;
using System.Collections.Generic;

namespace HSFFinance.Models
{
	public class LatestThinkingModel
	{

		public string Title { private set; get; }
		public string Image { get; set; }
		public UInt32 nid { get; set; }

		public LatestThinkingModel (UInt32 nid,string title, string img)
		{
			this.nid = nid;
			this.Title = title;
			this.Image = img;
		}

	}
}
