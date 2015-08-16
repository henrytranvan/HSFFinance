using Xamarin.Forms;

namespace HSFFinance.Views 
{
	public class MenuCell : ViewCell
{
	public MenuCell ()
	{
			this.Height = 70;
			var title = new Label
			{
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontSize = 21,
				FontAttributes = FontAttributes.Bold,

			};

			title.SetBinding(Label.TextProperty, "Title");

			var cntViewTitle = new ContentView {
				Content = title,
				BackgroundColor = Color.FromRgb(1,112,126),
				HeightRequest = 70,
				HorizontalOptions = LayoutOptions.FillAndExpand,

			};				
		
			View = new StackLayout
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = { cntViewTitle },
				HeightRequest = 80,
				Padding = new Thickness(0,2,0,2),

			};

	}
}
}