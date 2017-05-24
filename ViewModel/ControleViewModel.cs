using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using ePortaria.Helper;
using ePortaria.Model;

namespace ePortaria.ViewModel
{
	public class ControleViewModel : ViewModelBase, INotifyPropertyChanged
	{

        private int _id;
        private string _descricao;
        private string _conexao;
        private string _status;
        private string _ip;
        private string _nome_bluetooth;
		private ObservableCollection<Controle> _listaControle;

		public int Id
		{
			get { return _id; }
			set
			{
                if (value != _id)
				{
					_id = value;
					OnPropertyChanged("Id");
				}
			}
		}
		public string Descricao
		{
            get { return _descricao; }
			set
			{
                if (value != _descricao)
				{
                    _descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}
		public string Conexao
		{
            get { return _conexao; }
			set
			{
                if (value != _conexao)
				{
                    _conexao = value;
					OnPropertyChanged("Conexao");
				}
			}
		}
		public string Status
		{
            get { return _status; }
			set
			{
                if (value != _status)
				{
                    _status = value;
					OnPropertyChanged("Status");
				}
			}
		}
		public string Ip
		{
            get { return _ip; }
			set
			{
				if (value != _ip)
				{
					_ip = value;
					OnPropertyChanged("Ip");
				}
			}
		}
		public string NomeBluetooth
		{
            get { return _nome_bluetooth; }
			set
			{
                if (value != _nome_bluetooth)
				{
                    _nome_bluetooth = value;
					OnPropertyChanged("NomeBluetooth");
				}
			}
		}
		

		public ObservableCollection<Controle> ListaControle
		{
			get
			{
                if (_listaControle != null)
				{
                    return _listaControle;
				}
				else
				{
                    _listaControle = new ObservableCollection<Controle>();
                    return _listaControle;
				}
			}

			set
			{
				_listaControle = value;
				OnPropertyChanged("ListaControle");
			}
		}

		public ControleViewModel()
		{

		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}

	}
}
