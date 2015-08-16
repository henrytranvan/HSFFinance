using System;
using System.Collections.Generic;
using HSFFinance.Models;

namespace HSFFinance.ViewModels
{
	public class LatestThinkingViewModel : List<LatestThinkingModel>
	{


		public LatestThinkingViewModel ()
		{
			 var ltmodel = new List<LatestThinkingModel> () {
				new LatestThinkingModel (1, "The golden lion tamarin also known as the golden marmoset, is a small New Worl richidae", "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Cercopithecus_neglectus.jpg/220px-Cercopithecus_neglectus.jpg"),
				new LatestThinkingModel (2, "Part 1: Is innovation in funding the answer? – Metal streaming", "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Cercopithecus_neglectus.jpg/220px-Cercopithecus_neglectus.jpg"),
				new LatestThinkingModel (3, "Part 2: Is innovation in funding the answer? – Royalty financing", "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Cercopithecus_neglectus.jpg/220px-Cercopithecus_neglectus.jpg"),
		 };

			this.AddRange (ltmodel);

		}
	}
}

