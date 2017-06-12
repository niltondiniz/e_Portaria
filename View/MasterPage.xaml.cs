using System;
using System.Collections.Generic;
using ePortaria.ViewModel;
using ePortaria.Model;

using Xamarin.Forms;

namespace ePortaria
{
	public partial class MasterPage : ContentPage
	{

		public ListView ListView { get { return listView; } }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public string Imagem { get; set; }
        public List<MasterPageItem> masterPageItems { get; set; }

		public MasterPage()
		{
			BindingContext = ((App)App.Current).masterPageViewModel;
			InitializeComponent();

			masterPageItems = new List<MasterPageItem>();

            foreach(Estabelecimento estabelecimentos in ((App)App.Current).estabelecimentoVW.ListaEstabelecimento)
            {
                masterPageItems.Add(new MasterPageItem
                {
                    Title = estabelecimentos.Nome, 
                    IconSource = "ic_home.png", 
                    TargetType = typeof(Controle), 
                    Estabelecimento = estabelecimentos
                });
            }
			masterPageItems.Add(new MasterPageItem
			{
				Title = " ",
				IconSource = "",
				TargetType = typeof(ePortariaPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Configurações",
				IconSource = "ic_settings.png",
				TargetType = typeof(ePortariaPage)
			});
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Perfil",
                IconSource = "ic_settings.png",
                TargetType = typeof(Perfil),
                Estabelecimento = new Estabelecimento()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Sobre",
				IconSource = "ic_information.png",
				TargetType = typeof(ePortariaPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Sair",
				IconSource = "ic_exit_to_app.png",
				TargetType = typeof(ePortariaPage)
			});
			ListView.ItemsSource = masterPageItems;

		}
	}
}
