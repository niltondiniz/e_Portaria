using System;
using System.Collections.Generic;

namespace ePortaria.Model
{
	public class Usuario
	{
		public Entidade entidade { get; set; }
		public List<Estabelecimento> estabelecimento { get; set; }
	}
}
