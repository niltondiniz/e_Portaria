using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using ePortaria.Helper;
using ePortaria.Model;
using Newtonsoft.Json;

namespace ePortaria.ViewModel
{
    public class EntidadeViewModel: ViewModelBase, INotifyPropertyChanged
    {

        private int _id;
        private string _fk_permissao;
        private object _fk_usuario_responsavel;
        private string _fk_ibge_cidade;
        private string _nome;
        private string _telefone;
        private string _telefone2;
        private string _imei;
        private string _email;
        private string _senha;
        private string _endereco;
        private string _bairro;
        private string _numero;
        private string _cep;
        private object _acesso;
        private string _status;
        private object _codigo_senha;
        private object _codigo_tempo;
        private string _dt_cadastro;
        private string _dt_modificado;
        private string _mensagem;
        public ObservableCollection<Estabelecimento> _listaEstabelecimento;
        public ObservableCollection<KeyValuePair<String, String>> _dadosPerfil;

		
		public int Id 
        { 
            get { return _id; } 
            set
            {
                if(value != _id)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }    
            } 
        }
		public string Fk_permissao
		{
            get { return _fk_permissao; }
			set
			{
                if (value != _fk_permissao)
				{
                    _fk_permissao = value;
					OnPropertyChanged("Fk_permissao");
				}
			}
		}
		public object Fk_usuario_responsavel
		{
			get { return _fk_usuario_responsavel; }
			set
			{
				if (value != Fk_usuario_responsavel)
				{
					Fk_usuario_responsavel = value;
					OnPropertyChanged("Fk_usuario_responsavel");
				}
			}
		}
		public string Fk_ibge_cidade
		{
			get { return _fk_ibge_cidade; }
			set
			{
				if (value != _fk_ibge_cidade)
				{
                    _fk_ibge_cidade = value;
					OnPropertyChanged("Fk_ibge_cidade");
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
		public string Telefone2
		{
			get { return _telefone2; }
			set
			{
				if (value != _telefone2)
				{
					_telefone2 = value;
					OnPropertyChanged("Telefone2");
				}
			}
		}
		public string Imei
		{
			get { return _imei; }
			set
			{
                if (_imei == null)
                    _imei = "";
                
				if (value != _imei)
				{
					_imei = value;
					//OnPropertyChanged("Imei");
				}
			}
		}
		public string Email
		{
			get { return _email; }
			set
			{
                if (_email == null)
                    _email = "";
                
				if (value != _email)
				{
					_email = value;
					//OnPropertyChanged("Email");
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
		public object Acesso
		{
			get { return _acesso; }
			set
			{
				if (value != _acesso)
				{
					_acesso = value;
					OnPropertyChanged("Acesso");
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
		public object Codigo_senha
		{
			get { return _codigo_senha; }
			set
			{
				if (value != _codigo_senha)
				{
					_codigo_senha = value;
					OnPropertyChanged("Codigo_senha");
				}
			}
		}
		public object Codigo_tempo
		{
			get { return _codigo_tempo; }
			set
			{
				if (value != _codigo_tempo)
				{
					_codigo_tempo = value;
					OnPropertyChanged("Codigo_tempo");
				}
			}
		}
		public string Dt_cadastro
		{
			get { return _dt_cadastro; }
			set
			{
				if (value != _dt_cadastro)
				{
					_dt_cadastro = value;
					OnPropertyChanged("Dt_cadastro");
				}
			}
		}
		public string Dt_modificado
		{
			get { return _dt_modificado; }
			set
			{
				if (value != _dt_modificado)
				{
					_dt_modificado = value;
					OnPropertyChanged("Dt_modificado");
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

        public ObservableCollection<KeyValuePair<String, String>> DadosPerfil
        {
			get
			{
                if (_dadosPerfil != null)
				{
                    return _dadosPerfil;
				}
				else
				{
                    _dadosPerfil = new ObservableCollection<KeyValuePair<string, string>>();
                    return _dadosPerfil;
				}
			}

			set
			{
                _dadosPerfil = value;
				OnPropertyChanged("DadosPerfil");
			} 
        }

		public string Mensagem
		{
			get { return _mensagem; }
			set
			{
				if (value != _mensagem)
				{
					_mensagem = value;
					OnPropertyChanged("Mensagem");
				}
			}
		}

        public EntidadeViewModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
		
        private void OnPropertyChanged(string nome)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}

        public void PerfilToLista(Entidade entidade)
        {
            /*this._dadosPerfil.Add(new KeyValuePair<String, String>("Id", entidade.id));
            this._dadosPerfil.Add(new KeyValuePair<String, String>("FK_Permissao", entidade.fk_permissao));
			this._dadosPerfil.Add(new KeyValuePair<String, String>("fk_usuario_responsavel", entidade.fk_usuario_responsavel));
            this._dadosPerfil.Add(new KeyValuePair<String, String>("fk_ibge_cidade", entidade.fk_ibge_cidade));*/
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Nome", entidade.nome));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Telefone", entidade.telefone));
			this.DadosPerfil.Add(new KeyValuePair<String, String>("Celular", entidade.telefone2));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("IMEI", entidade.imei));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Email", entidade.email));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Senha", entidade.senha));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Endereço", entidade.endereco));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Bairro", entidade.bairro));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Número", entidade.numero));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("CEP", entidade.cep));
            this.DadosPerfil.Add(new KeyValuePair<String, String>("Acesso", entidade.acesso));
            /*this._dadosPerfil.Add(new KeyValuePair<String, String>("Status", entidade.status));
            this._dadosPerfil.Add(new KeyValuePair<String, String>("Codigo Senha", entidade.codigo_senha));
            this._dadosPerfil.Add(new KeyValuePair<String, String>("Data Cadastro", entidade.dt_cadastro));
            this._dadosPerfil.Add(new KeyValuePair<String, String>("Data Alterado", entidade.dt_modificado));*/

        }

        public void DadosToVM(Entidade entidade)
        {
            this._id = entidade.id;
            this._fk_permissao = entidade.fk_permissao;
            this._fk_usuario_responsavel = entidade.fk_usuario_responsavel;
            this._fk_ibge_cidade = entidade.fk_ibge_cidade;
            this._nome = entidade.nome;
            this._telefone = entidade.telefone;
            this._telefone2 = entidade.telefone2;
            this._imei = entidade.imei;
            this._email = entidade.email;
            this._senha = entidade.senha;
            this._endereco = entidade.endereco;
            this._bairro = entidade.bairro;
            this._numero = entidade.numero;
            this._cep = entidade.cep;
            this._acesso = entidade.acesso;
            this._status = entidade.status;
            this._codigo_senha = entidade.codigo_senha;
            this._dt_cadastro = entidade.dt_cadastro;
            this._dt_modificado = entidade.dt_modificado;
        }

        public async Task<Usuario> GetDados(string email, string imei)
		{
			try
            {
                var resultado = await RequestClient.GetRequest(RequestClient.httpBase, RequestClient.httpCompl, email, imei);
                Response resposta = JsonConvert.DeserializeObject<Response>(resultado);
                if (resposta.data.usuario != null)
                {
                    DadosToVM(resposta.data.usuario.entidade);
                    PerfilToLista(resposta.data.usuario.entidade);
                    return resposta.data.usuario;
                }else{
                    return null;
                }

            }
            catch (Exception e)
			{
				Debug.WriteLine(e.Message);
                return null;
			}
		}
    }
}
