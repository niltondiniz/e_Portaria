using System;
using Xamarin.Forms;

namespace ePortaria
{
	public partial class ePortariaPage : ContentPage
	{
        private string Titulo;
		public ePortariaPage()
		{
            //BindingContext = ((App)App.Current).EntidadeVM;
            InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
            ((App)App.Current).MainPage.Title = ((App)App.Current).EnderecoIp;
		}
	}
}
