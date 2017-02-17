using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ePortaria
{
	public partial class MasterPage : ContentPage
	{

		public ListView ListView { get { return listView; } }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public string Imagem { get; set; }

		public MasterPage()
		{
			BindingContext = ((App)App.Current).masterPageViewModel;
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Garagem AP",
				IconSource = "ic_home.png",
				TargetType = typeof(ePortariaPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Loja Vila Isabel",
				IconSource = "ic_cart.png",
				TargetType = typeof(ePortariaPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Loja Centro",
				IconSource = "ic_cart.png",
				TargetType = typeof(ePortariaPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Armazém",
				IconSource = "ic_store.png",
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
				Title = "Sobre",
				IconSource = "ic_information.png",
				TargetType = typeof(ePortariaPage)
			});
			ListView.ItemsSource = masterPageItems;

		}
	}
}
