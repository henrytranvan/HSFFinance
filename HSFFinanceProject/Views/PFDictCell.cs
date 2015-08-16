using Xamarin.Forms;

namespace HSFFinance.Views
{
	public class PFDictCell : ViewCell
	{
		public PFDictCell ()
		{
			StackLayout cellWrapper = new StackLayout ();
			StackLayout virticalLayout = new StackLayout ();
			Label lblTitle = new Label ();
			lblTitle.FontAttributes = FontAttributes.Bold;
			lblTitle.TextColor =  Color.FromRgb (0, 112, 116);
			lblTitle.SetBinding (Label.TextProperty, "Title");

			Label lblDefinition = new Label ();
			lblDefinition.TextColor = Color.FromHex ("#000");
			lblDefinition.SetBinding (Label.TextProperty, "Definition");



			cellWrapper.BackgroundColor = Color.White;
			virticalLayout.Orientation = StackOrientation.Vertical;
			virticalLayout.Padding = new Thickness (10,10,10,10);


			//add views to the view hierarchy
			virticalLayout.Children.Add (lblTitle);

			virticalLayout.Children.Add (lblDefinition);

			cellWrapper.Children.Add (virticalLayout);
			cellWrapper.HeightRequest = 80;
			View = cellWrapper;
		}
	}
}



