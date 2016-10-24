using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace UHappening
{
	public class MonkeyDataModel
	{

		public string Name { set; get; }

		public string Family { set; get; }

		public string Subfamily { set; get; }

		public string Tribe { set; get; }

		public string Genus { set; get; }

		public string PhotoUrl { set; get; }

		public static IList<MonkeyDataModel> All { set; get; }

		static MonkeyDataModel()
		{
			All = new ObservableCollection<MonkeyDataModel> {
				new MonkeyDataModel {
					Name = "Chimpanzee",
					Family = "Hominidae",
					Subfamily = "Homininae",
					Tribe = "Panini",
					Genus = "Pan",
					PhotoUrl = "http://nevadasoccer.org/wp-content/uploads/2014/10/person.png"
				},
				new MonkeyDataModel {
					Name = "Orangutan",
					Family = "Hominidae",
					Subfamily = "Ponginae",
					Genus = "Pongo",
					PhotoUrl = "http://nevadasoccer.org/wp-content/uploads/2014/10/person.png"
				}

			};
		}
	}
}
