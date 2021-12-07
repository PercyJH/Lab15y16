using TodoREST.Data;
using TodoREST.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoREST
{
	public partial class App : Application
	{
		public static TodoItemManager todoItemManager { get; private set; }
		public App()
		{
			todoItemManager = new TodoItemManager(new RestService());
			MainPage = new NavigationPage(new Views.ItemListPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

