using System;
using Xamarin.Forms;
using ePortaria.Model;

namespace ePortaria
{
	public class AcessoDados : IDisposable
	{
		private SQLite.Net.SQLiteConnection _conexao;

		public AcessoDados()
		{
			var config = DependencyService.Get<IConfig>();
			_conexao = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioDB, "bancodados2.db3"));

            _conexao.CreateTable<Entidade>();
            _conexao.CreateTable<Estabelecimento>();
		}

		public void Dispose()
		{
			_conexao.Dispose();
		}
	}
}
