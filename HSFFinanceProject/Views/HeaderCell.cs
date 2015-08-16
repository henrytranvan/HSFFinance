using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HSFFinance.Views
{
  public class HeaderCell : ViewCell
  {
    public HeaderCell()
    {
      this.Height = 25;
      var title = new Label
      {
        TextColor = Color.FromRgb(0, 50, 75),
        VerticalOptions = LayoutOptions.Center
      };

      title.SetBinding(Label.TextProperty, "Key");

      View = new StackLayout
      {
        HorizontalOptions = LayoutOptions.FillAndExpand,
        HeightRequest = 25,
        BackgroundColor = Color.FromRgb(238, 239, 239),
        Orientation = StackOrientation.Horizontal,
        Children = { title },
		
					
      };
    }
  }
}
