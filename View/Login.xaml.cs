
using System;
using ePortaria.Helper;
using Plugin.DeviceInfo;
using Xamarin.Forms;

namespace ePortaria
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            BindingContext = ((App)App.Current).EntidadeVM;
            InitializeComponent();
        }

		async void OnButtonClicked(object sender, EventArgs args)
		{
            ((App)Application.Current).EntidadeVM.Imei = CrossDevice.Hardware.DeviceId;

            var logado = await ((App)Application.Current).EntidadeVM.GetDados(((App)Application.Current).EntidadeVM.Email, ((App)Application.Current).EntidadeVM.Imei.Substring(0,20));
            if(logado)
            {
                ((App)App.Current).MainPage = new Main();
            }
            else
            {
                ((App)App.Current).EntidadeVM.Email = "Deu Ruim!";
            }
        }

    }
}
