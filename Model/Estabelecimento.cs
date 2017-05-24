using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite.Net.Attributes;

namespace ePortaria.Model
{
    [Table("Estabelecimento")]
    public class Estabelecimento: ModelBase
    {
        [PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Senha { get; set; }
		public string Endereco { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Uf { get; set; }
		public string Numero { get; set; }
		public string Cep { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string IdAcesso { get; set; }
		public string Seg_inicio { get; set; }
		public string Seg_fim { get; set; }
		public string Ter_inicio { get; set; }
		public string Ter_fim { get; set; }
		public string Qua_inicio { get; set; }
		public string Qua_fim { get; set; }
		public string Qui_inicio { get; set; }
		public string Qui_fim { get; set; }
		public string Sex_inicio { get; set; }
		public string Sex_fim { get; set; }
		public string Sab_inicio { get; set; }
		public string Sab_fim { get; set; }
		public string Dom_inicio { get; set; }
		public string Dom_fim { get; set; }
		public string StatusAcesso { get; set; }
		
        [Ignore]
        public List<Controle> Controle { get; set; }

        public Estabelecimento()
        {
        }
    }
}
