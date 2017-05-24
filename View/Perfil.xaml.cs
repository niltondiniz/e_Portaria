using System;
using System.Collections.Generic;
using ePortaria.ViewModel;

using Xamarin.Forms;

namespace ePortaria
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            //var entidadeVM = new EntidadeViewModel();
            //entidadeVM.GetDados();
            BindingContext = ((App)App.Current).EntidadeVM;
            InitializeComponent();
        }
    }
}
