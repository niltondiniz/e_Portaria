using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using ePortaria.Helper;
using ePortaria.Model;

namespace ePortaria.ViewModel
{
    public class EstabelecimentoViewModel : ViewModelBase, INotifyPropertyChanged
	{


        private int _id;
        private string _nome;
        private string _telefone;
        private string _senha;
        private string _endereco;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _numero;
        private string _cep;
        private string _latitude;
        private string _longitude;
        private string _idAcesso;
        private string _seg_inicio;
        private string _seg_fim;
        private string _ter_inicio;
        private string _ter_fim;
        private string _qua_inicio;
        private string _qua_fim;
        private string _qui_inicio;
        private string _qui_fim;
        private string _sex_inicio;
        private string _sex_fim;
        private string _sab_inicio;
        private string _sab_fim;
        private string _dom_inicio;
        private string _dom_fim;
        private string _statusAcesso;
        private ObservableCollection<Controle> _controle;
        private ObservableCollection<Estabelecimento> _listaEstabelecimento;


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
        public string Nome
		{
			get { return _nome; }
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}
        public string Telefone
		{
			get { return _telefone; }
			set
			{
				if (value != _telefone)
				{
					_telefone = value;
					OnPropertyChanged("Telefone");
				}
			}
		}
		public string Senha
		{
            get { return _senha; }
			set
			{
                if (value != _senha)
				{
                    _senha = value;
					OnPropertyChanged("Senha");
				}
			}
		}
		public string Endereco
		{
            get { return _endereco; }
			set
			{
                if (value != _endereco)
				{
                    _endereco = value;
					OnPropertyChanged("Endereco");
				}
			}
		}
		public string Bairro
		{
            get { return _bairro; }
			set
			{
                if (value != _bairro)
				{
                    _bairro = value;
					OnPropertyChanged("Bairro");
				}
			}
		}
		public string Cidade
		{
			get { return _cidade; }
			set
			{
				if (value != _cidade)
				{
					_cidade = value;
					OnPropertyChanged("Cidade");
				}
			}
		}
        public string Uf
		{
			get { return _uf; }
			set
			{
                if (value != _uf)
				{
                    _uf = value;
					OnPropertyChanged("Uf");
				}
			}
		}
		public string Numero
		{
			get { return _numero; }
			set
			{
				if (value != _numero)
				{
					_numero = value;
					OnPropertyChanged("Numero");
				}
			}
		}
		public string Cep
		{
			get { return _cep; }
			set
			{
				if (value != _cep)
				{
					_cep = value;
					OnPropertyChanged("Cep");
				}
			}
		}
		public string Latitude
		{
            get { return _latitude; }
			set
			{
                if (value != _latitude)
				{
                    _latitude = value;
					OnPropertyChanged("Latitude");
				}
			}
		}
		public string Longitude
		{
            get { return _longitude; }
			set
			{
                if (value != _longitude)
				{
                    _longitude = value;
					OnPropertyChanged("Longitude");
				}
			}
		}
        public string SegInicio
        {
            get { return _seg_inicio; }
            set
            {
                if (value != _seg_inicio)
                {
                    _seg_inicio = value;
                    OnPropertyChanged("SegInicio");
                }
            }
        }
		public string SegFim
        {
            get { return _seg_fim; }
            set
            {
                if (value != _seg_fim)
                {
                    _seg_fim = value;
                    OnPropertyChanged("SegFim");
                }
            }
        }
        public string TerInicio
        {
            get { return _ter_inicio; }
            set
            {
                if (value != _ter_inicio)
                {
                    _ter_inicio = value;
                    OnPropertyChanged("TerInicio");
                }
            }
        }
        public string TerFim
        {
            get { return _ter_fim; }
            set
            {
                if (value != _ter_fim)
                {
                    _ter_fim = value;
                    OnPropertyChanged("TerFim");
                }
            }
        }
        public string QuaInicio
        {
            get { return _qua_inicio; }
            set
            {
                if (value != _qua_inicio)
                {
                    _qua_inicio = value;
                    OnPropertyChanged("QuaInicio");
                }
            }
        }
        public string QuaFim
        {
            get { return _qua_fim; }
            set
            {
                if (value != _qua_fim)
                {
                    _qua_fim = value;
                    OnPropertyChanged("QuaFim");
                }
            }
        }
        public string QuiInicio
        {
            get { return _qui_inicio; }
            set
            {
                if (value != _qui_inicio)
                {
                    _qui_inicio = value;
                    OnPropertyChanged("QuiInicio");
                }
            }
        }
        public string QuiFim
        {
            get { return _qui_fim; }
            set
            {
                if (value != _qui_fim)
                {
                    _qui_fim = value;
                    OnPropertyChanged("QuiFim");
                }
            }
        }
        public string SexInicio
        {
            get { return _sex_inicio; }
            set
            {
                if (value != _sex_inicio)
                {
                    _sex_inicio = value;
                    OnPropertyChanged("SexInicio");
                }
            }
        }
        public string SexFim
        {
            get { return _sex_fim; }
            set
            {
                if (value != _sex_fim)
                {
                    _sex_fim = value;
                    OnPropertyChanged("SexFim");
                }
            }
        }
        public string SabInicio
        {
            get { return _sab_inicio; }
            set
            {
                if (value != _sab_inicio)
                {
                    _sab_inicio = value;
                    OnPropertyChanged("SabInicio");
                }
            }
        }
        public string SabFim
        {
            get { return _sab_fim; }
            set
            {
                if (value != _sab_fim)
                {
                    _sab_fim = value;
                    OnPropertyChanged("SabFim");
                }
            }
        }
        public string DomInicio
        {
            get { return _dom_inicio; }
            set
            {
                if (value != _dom_inicio)
                {
                    _dom_inicio = value;
                    OnPropertyChanged("DomInicio");
                }
            }
        }
        public string DomFim
        {
            get { return _dom_fim; }
            set
            {
                if (value != _dom_fim)
                {
                    _dom_fim = value;
                    OnPropertyChanged("DomFim");
                }
            }
        }
        public string StatusAcesso
        {
            get { return _statusAcesso; }
            set
            {
                if (value != _statusAcesso)
                {
                    _statusAcesso = value;
                    OnPropertyChanged("StatusAcesso");
                }
            }
        }
		public ObservableCollection<Estabelecimento> ListaEstabelecimento
		{
			get
			{
				if (_listaEstabelecimento != null)
				{
					return _listaEstabelecimento;
				}
				else
				{
					_listaEstabelecimento = new ObservableCollection<Estabelecimento>();
					return _listaEstabelecimento;
				}
			}

			set
			{
				_listaEstabelecimento = value;
				OnPropertyChanged("ListaEstabelecimento");
			}
		}

        public ObservableCollection<Controle> ListaControle
        {
            get
            {
                if (_controle != null)
                {
                    return _controle;
                }
                else
                {
                    _controle = new ObservableCollection<Controle>();
                    return _controle;
                }
            }

            set
            {
                _controle = value;
                OnPropertyChanged("ListaControle");
            }
        }

		public EstabelecimentoViewModel()
		{

		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}
		
	}
}
