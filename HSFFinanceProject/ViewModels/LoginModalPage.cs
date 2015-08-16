using System;
using Xamarin.Forms;

namespace HSFFinanceProject
{
	public class LoginModalPage : CarouselPage
	{
		ContentPage login, create;
		public LoginModalPage (ILoginManager ilm)
		{
			login = new LoginPage (ilm);
			this.Children.Add (login);

			MessagingCenter.Subscribe<ContentPage> (this, "Login", (sender) => {
				this.SelectedItem = login;
			});
			MessagingCenter.Subscribe<ContentPage> (this, "Create", (sender) => {
				this.SelectedItem = create;
			});
		}
	}
}

