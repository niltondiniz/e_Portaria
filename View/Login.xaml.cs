
using System;
using ePortaria.Helper;
using ePortaria.Model;
using Plugin.DeviceInfo;
using Xamarin.Forms;

namespace ePortaria
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            BindingContext = ((App)App.Current).entidadeVM;
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            ((App)App.Current).entidadeVM.Mensagem = "";
            ((App)App.Current).GerenciaLoginAsync();
        }

    }
}
