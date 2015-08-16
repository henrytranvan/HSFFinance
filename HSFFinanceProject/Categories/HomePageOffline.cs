using System;
using Xamarin.Forms;

using HSFFinance.Models;
using HSFFinance.ViewModels;
using HSFFinance.Views;

namespace HSFFinanceProject
{
	public class HomePageOffline : ContentPage
	{
		LatestThinkingView latestthinkinglist;
		LatestThinkingView latestnews;
	
		public HomePageOffline ()
		{
			Title = "Home Page".ToUpper();

			BackgroundColor = Color.FromRgb (238, 239, 239);
			var settings = new ToolbarItem
			{
				Text = "Logout",
				Command = new Command(this.ShowSettingsPage),
			};

			this.ToolbarItems.Add (settings);



			Button buttonLatestThinking = new Button
			{  
				Text = "Latest Thinking".ToUpper(),
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
			    HeightRequest = 50,
				BackgroundColor = Color.FromRgb(1,112,126),
				TextColor = Color.White,
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttonLatestThinking.Clicked += OnButtonClicked;

			var latesttinkinglayout = new ContentView {
				Content = buttonLatestThinking,
				BackgroundColor = Color.FromRgb(0,112,126),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};

  		    latestthinkinglist = new LatestThinkingView ();
		
			Button buttonlatestthinkingviewmore = new Button
			{
				Text = "View more ....",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 50,
				BackgroundColor = Color.White,
				TextColor = Color.FromRgb(0,112,126),
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttonlatestthinkingviewmore.Clicked += OnButtonClicked;

			var latesttinkingviewmorelayout = new ContentView {
				Content = buttonlatestthinkingviewmore,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};

			Button buttonpfdictionary = new Button
			{
				Text = "PF Dictionary".ToUpper(),
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 50,
				BackgroundColor = Color.FromRgb(1,112,126),
				TextColor = Color.White,
				BorderRadius = 0,
				Image = "arrowicon.png",

			};
			buttonpfdictionary.Clicked += OnButtonClicked;

			var pfDictlayout = new ContentView {
				Content = buttonpfdictionary,
				BackgroundColor = Color.FromRgb(0,112,126),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};


			Label lblDic = new Label {
				Text = "Aliquam ut maximus nisl. Nam convallis ultrices velit, sit amet auctor lectus gravida id. Nunc at leo augue. Ut sed enim id sapien venenatis .",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
				

			Button buttonViewmorePFDict = new Button
			{
				Text = "View more ....",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 50,
				BackgroundColor = Color.White,
				TextColor = Color.FromRgb(0,112,126),
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttonViewmorePFDict.Clicked += OnButtonClicked;

			var morepfDictlayout = new ContentView {
				Content = buttonViewmorePFDict,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};


			Button buttonLatestNews = new Button
			{
				Text = "Latest News".ToUpper(),
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 50,
				BackgroundColor = Color.FromRgb(1,112,126),
				TextColor = Color.White,
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttonLatestNews.Clicked += OnButtonClicked;

			var latestnewslayout = new ContentView {
				Content = buttonLatestNews,
				BackgroundColor = Color.FromRgb(0,112,126),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};

			latestnews = new LatestThinkingView ();

			Button buttonmorenews = new Button
			{
				Text = "View more ....",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 50,
				BackgroundColor = Color.White,
				TextColor = Color.FromRgb(0,112,126),
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttonmorenews.Clicked += OnButtonClicked;

			var morenewslayout = new ContentView {
				Content = buttonmorenews,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};

			Button buttonsectornews = new Button
			{
				Text = "SECTOR NEWS",
				HorizontalOptions = LayoutOptions.Start,
				HeightRequest = 60,
				BackgroundColor = Color.FromRgb(1,112,126),
				TextColor = Color.White,
				BorderRadius = 0,
				Image = "arrowicon.png",

			};
				
			buttonsectornews.Clicked += OnButtonClicked;

			var sectornewstlayout = new ContentView {
				Content = buttonsectornews,
				BackgroundColor = Color.FromRgb(1,112,126),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};


			Button buttoncontactus = new Button
			{
				Text = "Contact Us".ToUpper(),
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.StartAndExpand,
				HeightRequest = 50,
				BackgroundColor = Color.FromRgb(1,112,126),
				TextColor = Color.White,
				BorderRadius = 0,
				Image = "arrowicon.png",
			};
			buttoncontactus.Clicked += OnButtonClicked;


			var contactlayout = new ContentView {
				Content = buttoncontactus,
				BackgroundColor = Color.FromRgb(1,112,126),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(0,5,0,5),
			};


			var lblFooter = new Label {
				Text = "Morbi a sagittis massa. Nunc quis viverra arcu, auctor tristique turpis. Nam quis nisi eget felis ullamcorper condimentum.",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb (0, 50,75),
				HorizontalOptions = LayoutOptions.Start,

			};

			var lbllayout = new ContentView {
				Content = lblFooter,
				Padding = new Thickness(18,0,10,10),
				BackgroundColor = Color.FromRgb (0, 50,75),
			};


			var footer = new FooterView ();

            var stack = new StackLayout () {

				Orientation = StackOrientation.Vertical,
				HorizontalOptions=LayoutOptions.FillAndExpand,
				Spacing = 0,  

				Children = {
					latesttinkinglayout,
					latestthinkinglist,
					latesttinkingviewmorelayout,
					pfDictlayout,
					lblDic,
					morepfDictlayout,
					latestnewslayout,
					latestnews,
					morenewslayout,
					sectornewstlayout,
					contactlayout,
					footer,
					lbllayout
				},
			};


			var scrollview = new ScrollView {
				Content =  stack,

			};

         
			Content = scrollview;


		}

		private void ShowSettingsPage()
		{
			this.Navigation.PushAsync(new SectorNewsPage());
		}

		void OnButtonClicked (object s, EventArgs e) {

		}
	}

}
