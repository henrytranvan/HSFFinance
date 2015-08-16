using System;
using Xamarin.Forms;

using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;


namespace HSFFinanceProject
{
	public class App : Application

	{
		public App ()
		{
			
			//check_login ();

			MainPage = new HomePage ();


		}
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		/*
		public async Task check_login() {

			//var hsfClient = new System.Net.Http.HttpClient();  
			//hsfClient.BaseAddress = new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/");  

			//StringContent str = new StringContent("postalcode=752020&country=IN&username=nirmalh", Encoding.UTF8, "application/x-www-form-urlencoded");  

			//StringContent str = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");

			//hsfClient.DefaultRequestHeaders.Add ("X-CSRF-Token","8Vkx3mkBuzs8VMZnZV1Q7q1KsuRoQ_sVEQifDn5W3Bk");



			//var response =   await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/services/session/token"), str);  


			var client = new System.Net.Http.HttpClient();  
			client.BaseAddress = new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/");  

			//StringContent str = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");  
			//var response = await client.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/services/session/token"), str);  

		 
		   

			StringContent str3 = new StringContent("", Encoding.UTF8, "application/json");  
			var response3= await client.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=services/session/token"), str3);  

			var placesJson3 = response3.Content.ReadAsStringAsync().Result;   


			client.DefaultRequestHeaders.Add ("X-CSRF-Token",placesJson3);



			StringContent str = new StringContent("username=henry.tranvan@gmail.com&password=040778hu", Encoding.UTF8, "application/json");				
			var response =   await client.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsfendpoints/system/connect.json"), str);  


			var placesJson = response.Content.ReadAsStringAsync().Result;   



			StringContent str1 = new StringContent("username=henry.tranvan@gmail.com&password=040778hu", Encoding.UTF8, "application/x-www-form-urlencoded");		
			var response1 =   await client.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsfendpoints/user/login.json"), str1);  

			var placesJson1 = response1.Content.ReadAsStringAsync().Result;   

			client.DefaultRequestHeaders.Add("Cookie" = $authenticate['session_name'] . '=' . $authenticate['sessid'];



			StringContent str4 = new StringContent("username=henry.tranvan@gmail.com&password=040778hu", Encoding.UTF8, "application/json");				
			var response4 =   await client.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsfendpoints/system/connect.json"), str4);  


			var placesJson4= response.Content.ReadAsStringAsync().Result;   


		//	StringContent str = new StringContent("username=henry.tranvan@gmail.com&password=040778hu", Encoding.UTF8, "application/x-www-form-urlencoded");

			//var response =   await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsfendpoints/system/connect.json"), str);  

			//var response =   await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsfendpoints/user/login.json"), str);  


			//var response =  await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsf_finance/user/login.json"),str); 

			//var response =  await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/hsf_finance/user/login.json"),str);  



			//var user = response.Content.ReadAsStringAsync().Result;

			Properties ["IsLoggedIn"] = true;
			MainPage = new HomePage ();


		}
		*/


	}
}


 /*
		static ILoginManager loginManager;
		public static App Current;

		public App ()
		{

			Current = this;



			var chcklogined = check_login ();

			/*
			var placesJson = response.Content.ReadAsStringAsync().Result;  
			Placeobject placeobject = new Placeobject();  
			if(placesJson!="")  
			{  
				placeobject = JsonConvert.DeserializeObject<Placeobject>(placesJson);  
			}  
			return placeobject.places; 
*/

		/* 
			var isLoggedIn = Properties.ContainsKey("IsLoggedIn")?(bool)Properties ["IsLoggedIn"]:false;

			if (isLoggedIn) {
				MainPage = new HomePage();
			}
			else {
			
				MainPage = new LoginPage(this);
			
			}

		*/

	

	   

	/*
		public async Task check_login() {
			
			var hsfClient = new System.Net.Http.HttpClient();  
			hsfClient.BaseAddress = new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/");  
			hsfClient.
			//StringContent str = new StringContent("postalcode=752020&country=IN&username=nirmalh", Encoding.UTF8, "application/x-www-form-urlencoded");  

			//StringContent str = new StringContent("username=henry.tran@bienalto.com&password=040778hu", Encoding.UTF8, "application/x-www-form-urlencoded");

			StringContent str = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");

			var response =   await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsf_finance/system/connect.json"), str);  

			//var response =  await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/?q=hsf_finance/user/login.json"),str); 

			//var response =  await hsfClient.PostAsync(new Uri("http://herbertfinanaceachwqu4prq.devcloud.acquia-sites.com/hsf_finance/user/login.json"),str);  


			var user = response.Content.ReadAsStringAsync().Result;

			Properties ["IsLoggedIn"] = true;
			MainPage = new HomePage ();

			 
		}
		public void ShowMainPage ()
		{	
			MainPage = new HomePage ();
		}
		public void Logout ()
		{
			Properties ["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
			MainPage = new LoginModalPage (this);
		}
*/


    

