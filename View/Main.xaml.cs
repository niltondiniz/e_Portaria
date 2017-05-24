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

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;

                /*if(item.Estabelecimento != null)
                {
                    ((App)App.Current).EstabelecimentoVW.ControlDescricao = item.Estabelecimento.control_descricao;
                    ((App)App.Current).EstabelecimentoVW.ControlConexao = item.Estabelecimento.control_conexao;
                    ((App)App.Current).EstabelecimentoVW.ControlIp = item.Estabelecimento.control_ip;
                }
                    ((App)App.Current).EnderecoIp = item.Estabelecimento.control_ip;*/
			}

		}
	}
}
