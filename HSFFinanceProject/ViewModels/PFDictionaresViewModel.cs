using HSFFinance.Helpers;
using HSFFinance.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HSFFinance.ViewModels
{
	public class PFDictionaresViewModel 
	{
		public ObservableCollection<PFDictionary> PFDictionaries { get; set; }
		public ObservableCollection<Grouping<string, PFDictionary>> PFDictionariesGrouped { get; set; }

		public PFDictionaresViewModel()
			{
			    PFDictionaries = new ObservableCollection<PFDictionary>();
			    PFDictionaries.Add(new PFDictionary
					{
						Title =  "Baboon",
						Definition = "Baboons are African and Arabian Old World monkeys .",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Capuchin Monkey",
						Definition = "The capuchin monkeys are New World monkeys of .",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Blue Monkey",
						Definition = "The blue monkey or diademed monkey is a species of",
					});


				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Squirrel Monkey",
							Definition = "The squirrel monkeys are the New  as an English name by ers.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Golden Lion Tamarin",
						Definition = "The golden lion tamarin also known as the is.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Howler Monkey",
						Definition = "Howler monkeys arously classified re now placeelidae.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Japanese Macaque",
						Definition = "The Japanes because they live in areas wh",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Mandrill",
						Definition = "The mandrill is a primate of the Old Wo and Congo.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Proboscis Monkey",
						Definition = "The proboscis monkey ndemic too.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Spider Monkey",
						Definition = "Spider monkeys of the genus Attral il.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Saki Monkey",
						Definition = "Sakis, or saki monkeys, are ais of genus Chiropotes.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Emperor Tamarin",
						Definition = "The emperor tamarin, is a spen Amazonas",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Spectacled Langur",
						Definition = "The dusky leaf monkey, spectacledsiaThailand.",
						});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Colobus Monkey",
						Definition = "Blac is a stum than ino other primates.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "De Brazza's Monkey",
						Definition = "De Brazza widespread Africanve in forests.",
					});

				PFDictionaries.Add(new PFDictionary
					{
						Title =  "Chimpanzee",
						Definition = "Chimpanzees,e habitats of the two species",
					});

			   var sorted = from pfdic in PFDictionaries
				orderby pfdic.Title
				group pfdic by pfdic.TitleSort into pfdicGroup
				select new Grouping<string, PFDictionary>(pfdicGroup.Key, pfdicGroup);

			 PFDictionariesGrouped = new ObservableCollection<Grouping<string, PFDictionary>>(sorted);



			}



		}
		

	}
	