using System;
using SQLite.Net.Attributes;
namespace ePortaria.Model
{
    [Table("Controle")]
	public class Controle
	{
        [PrimaryKey, AutoIncrement]
		public int id { get; set; }
        public int estabelecimento { get; set; }
		public string descricao { get; set; }
		public string conexao { get; set; }
		public string status { get; set; }
		public string ip { get; set; }
		public string nome_bluetooth { get; set; }
	}
}
