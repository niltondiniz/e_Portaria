using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ePortaria
{
	public partial class Main : MasterDetailPage
	{
		public Main()
		{
			InitializeComponent();
			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		protected override void OnAppearing()
		{
            if (masterPage.masterPageItems.Count > 0)
                masterPage.ListView.SelectedItem = masterPage.masterPageItems[0];
        }

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                {
                    BarBackgroundColor = Color.FromHex("#00796B"),
                    BarTextColor = Color.White,
                };

				masterPage.ListView.SelectedItem = null;
				IsPresented = false;

                ((App)App.Current).controleViewModel.ListaControle.Clear();

                if(item.Estabelecimento != null)
                {
                    if (item.Estabelecimento.Controle != null)
                    {   
                        foreach (Model.Controle controle in item.Estabelecimento.Controle)
                        {
                            ((App)App.Current).controleViewModel.ListaControle.Add(controle);
                        }
                    }
                }
			}
		}
	}
}
