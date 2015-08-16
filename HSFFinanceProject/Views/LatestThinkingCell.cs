using Xamarin.Forms;

namespace HSFFinance.Views
{
	public class LatestThinkingCell : ViewCell
	{
		public LatestThinkingCell ()
		{
			var image = new Image ();
			StackLayout cellWrapper = new StackLayout ();
			StackLayout horizontalLayout = new StackLayout ();
			Label left = new Label ();

			//set bindings
			left.SetBinding (Label.TextProperty, "Title");
			image.SetBinding (Image.SourceProperty, "Image");

			//Set properties for desired design
			cellWrapper.BackgroundColor = Color.White;
			horizontalLayout.Orientation = StackOrientation.Horizontal;
			horizontalLayout.Padding = new Thickness (10,10,10,10);
			left.TextColor = Color.FromRgb(0, 112, 116);

			//add views to the view hierarchy
	
			horizontalLayout.Children.Add (left);
			horizontalLayout.Children.Add (image);
			cellWrapper.Children.Add (horizontalLayout);
			View = cellWrapper;
		}
	}
}

