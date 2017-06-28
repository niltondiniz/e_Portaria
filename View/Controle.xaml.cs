using System;
using System.Collections.Generic;
using ePortaria.ViewModel;
using Xamarin.Forms;
using ePortaria.Helper;

namespace ePortaria
{
    public partial class Controle : ContentPage
    {
        private ePortaria.Model.Controle controle = null;

        public Controle()
        {
            InitializeComponent();
            BindingContext = ((App)App.Current).controleViewModel;

			CarouselZoos.ItemSelected += (sender, args) =>
            {
                controle = args.SelectedItem as ePortaria.Model.Controle;
            	if (controle == null)
            		return;

                Title = controle.descricao;
            };

        }

        void SendCommand(object sender, EventArgs e)
        {
            //Verifica o tipo de controle
            if(controle.conexao=="1"||controle.conexao=="3"){
                //SendViaBluetooth(controle.bluetooth); 
            }else{
                RequestClient.SendControle(controle.ip, "/?1");
            }
        }
    }
}
