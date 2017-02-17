using Xamarin.Forms;

namespace ePortaria
{
	public partial class App : Application
	{

		public MasterPageViewModel masterPageViewModel;

		public App()
		{
			InitializeComponent();

			masterPageViewModel = new MasterPageViewModel();
			MainPage = new Main();

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
