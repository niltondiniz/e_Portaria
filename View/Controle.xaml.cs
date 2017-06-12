using System;
using System.Collections.Generic;
using ePortaria.ViewModel;
using Xamarin.Forms;

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
    }
}
