﻿using System;
using Xamarin.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace HSFFinanceProject
{
	public class LoginPage : ContentPage
	{
		Entry username, password;
		public LoginPage (ILoginManager ilm)
		{
			var button = new Button { Text = "Login" };
			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
				{
					DisplayAlert("Validation Error", "Username and Password are required", "Re-try");
				} else {
					// REMEMBER LOGIN STATUS!

					App.Current.Properties["IsLoggedIn"] = true;
					ilm.ShowMainPage();
				}
			};

			username = new Entry { Text = "" };
			password = new Entry { Text = "" };
			Content = new StackLayout {
				Padding = new Thickness (10, 40, 10, 10),
				Children = {
					new Label { Text = "Login", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }, 
					new Label { Text = "Username" },
					username,
					new Label { Text = "Password" },
					password,
					button
				}
			};
		}
	}
}

