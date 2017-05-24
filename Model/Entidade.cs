using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite.Net.Attributes;

namespace ePortaria.Model
{
    [Table("Entidade")]
    public class Entidade: ModelBase
    {
        [PrimaryKey, AutoIncrement]
        [JsonProperty("id")]
		public int id { get; set; }
		[JsonProperty("fk_permissao")]
        public string fk_permissao { get; set; }
		[JsonProperty("fk_usuario_responsavel")]
        public string fk_usuario_responsavel { get; set; }
		[JsonProperty("fk_ibge_cidade")]
        public string fk_ibge_cidade { get; set; }
		[JsonProperty("nome")]
        public string nome { get; set; }
		[JsonProperty("telefone")]
        public string telefone { get; set; }
		[JsonProperty("telefone2")]
        public string telefone2 { get; set; }
		[JsonProperty("imei")]
        public string imei { get; set; }
		[JsonProperty("email")]
        public string email { get; set; }
		[JsonProperty("senha")]
        public string senha { get; set; }
		[JsonProperty("endereco")]
        public string endereco { get; set; }
		[JsonProperty("bairro")]
        public string bairro { get; set; }
		[JsonProperty("numero")]
        public string numero { get; set; }
		[JsonProperty("cep")]
        public string cep { get; set; }
		[JsonProperty("acesso")]
        public string acesso { get; set; }
		[JsonProperty("status")]
        public string status { get; set; }
		[JsonProperty("codigo_senha")]
        public string codigo_senha { get; set; }
		[JsonProperty("codigo_tempo")]
        public string codigo_tempo { get; set; }
		[JsonProperty("dt_cadastro")]
        public string dt_cadastro { get; set; }
		[JsonProperty("dt_modificado")]
        public string dt_modificado { get; set; }

        [Ignore]
        public List<Estabelecimento> ListaEstabelecimento { get; set; }
         

        public Entidade()
        {
        }
    }
}
