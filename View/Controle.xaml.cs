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
            BindingContext = ((App)App.Current).EstabelecimentoVW;
            InitializeComponent();
        }
    }
}
