using Xamarin.Forms;
using ePortaria.ViewModel;
using ePortaria.Model;
using System.Threading.Tasks;
using System;
using Plugin.DeviceInfo;
using System.Collections.Generic;
using System.Diagnostics;

namespace ePortaria
{
	public partial class App : Application
	{

		public MasterPageViewModel masterPageViewModel;
        public EntidadeViewModel entidadeVM;
        public EstabelecimentoViewModel estabelecimentoVW;
        public ControleViewModel controleViewModel;
        public string EnderecoIp;

		public App()
		{
			InitializeComponent();

            //Inicializa os Models que serao usados no app
            entidadeVM = new EntidadeViewModel();
            estabelecimentoVW = new EstabelecimentoViewModel();
            controleViewModel = new ControleViewModel();

            //Verifica se tem um entidade inserida no banco
            var entidade = entidadeVM.GetLista<Entidade>();

            //Se houver
            if ( entidade.Count > 0 )
            {
                //se não estiver com login expirado
                if (entidade[0].dt_expiracao > DateTime.Now)
                {
                    //prepara os dados e vai para tela principal
                    //entidadeVM.DadosToVM(entidade[0]);
                    //entidadeVM.PerfilToLista(entidade[0]);
                    //estabelecimentoVW.EstabelecimentosVw(estabelecimentoVW.GetLista<Estabelecimento>());
                    //ScontroleViewModel.AddControles(estabelecimentoVW.ListaEstabelecimento);
                    entidadeVM.Email = entidade[0].email;
                    masterPageViewModel = new MasterPageViewModel();

                    GerenciaLoginAsync();
                    MainPage = new Main();
                }
                else
					MainPage = new Login();
            }
            else
            {
                MainPage = new Login();  
            }

		}

        public async void GerenciaLoginAsync()
        {
            List<Estabelecimento> estabelecimentos = new List<Estabelecimento>();

            try
            {
				//Pega o numero identificador do device
				entidadeVM.Imei = CrossDevice.Hardware.DeviceId;   
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            if (!string.IsNullOrEmpty(entidadeVM.Email))
            {

                //Faz login trazendo todos os dados do app
                Usuario usuario = null;
                var dadosUsuario = await this.entidadeVM.GetDados(entidadeVM.Email, entidadeVM.Imei);

                if (dadosUsuario != null)
                    usuario = dadosUsuario;

                if (usuario != null)
                {
                    var entidade = usuario.entidade;
                    estabelecimentos = usuario.estabelecimento;
                    entidade.dt_expiracao = DateTime.Now.AddDays(15);

                    //Login = true
                    if (!string.IsNullOrEmpty(entidade.imei))
                    {
                        //apaga tudo e insere novos dados
                        this.entidadeVM.DeleteAll<Entidade>();
                        this.entidadeVM.DeleteAll<Estabelecimento>();
                        this.entidadeVM.DeleteAll<ePortaria.Model.Controle>();
                        this.entidadeVM.Insert<Entidade>(entidade);

                        if (estabelecimentos != null)
                        {
                            foreach (Estabelecimento estabelecimento in estabelecimentos)
                            {
                                this.estabelecimentoVW.Insert<Estabelecimento>(estabelecimento);

                                if (estabelecimento.Controle != null)
                                {
                                    foreach (ePortaria.Model.Controle controle in estabelecimento.Controle)
                                    {
                                        controle.estabelecimento = estabelecimento.Id;
                                        this.controleViewModel.Insert<ePortaria.Model.Controle>(controle);
                                    }
                                }

                                this.estabelecimentoVW.ListaEstabelecimento.Add(estabelecimento);

                            }
                        }

                        this.MainPage = new Main();
                    }
                    else
                    {
                        this.entidadeVM.Mensagem = "Usuário não cadastrado";
                    }
                }
                else
                {
                    this.entidadeVM.Mensagem = "Você já está logado em outro dispositivo";
					this.MainPage = new Login();
                }

            }
            else
            {
                this.entidadeVM.Mensagem = "Preencha seu email";
            }
        }

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
