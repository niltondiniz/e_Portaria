using Xamarin.Forms;
using ePortaria.ViewModel;
using ePortaria.Model;
using System.Threading.Tasks;

namespace ePortaria
{
	public partial class App : Application
	{

		public MasterPageViewModel masterPageViewModel;
        public EntidadeViewModel EntidadeVM;
        public EstabelecimentoViewModel EstabelecimentoVW;
        public string EnderecoIp;

		public App()
		{
			InitializeComponent();

            EntidadeVM = new EntidadeViewModel();
            EstabelecimentoVW = new EstabelecimentoViewModel();
            //EntidadeVM.GetDados();


            if ( EntidadeVM.Id > 0 )
            {
				masterPageViewModel = new MasterPageViewModel();
				MainPage = new Main();
            }
            else
            {
                MainPage = new Login();  
            }

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
