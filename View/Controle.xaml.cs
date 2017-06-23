using System;
using System.Collections.Generic;
using ePortaria.ViewModel;
using Xamarin.Forms;
using ePortaria.Helper;

namespace ePortaria
{
    public partial class Controle : ContentPage
    {
        public Controle()
        {
            InitializeComponent();
            BindingContext = ((App)App.Current).controleViewModel;
            //listControles.ItemsSource = ((App)App.Current).controleViewModel.ListaControle;
        }

        void BleDevices(object sender, EventArgs e)
        {
            //((App)App.Current).controleViewModel.BleDevices();
            RequestClient.SendControle("http://192.168.1.62","/?1");
        }

    }
}
