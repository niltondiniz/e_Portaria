using System;
using ePortaria.Model;

namespace ePortaria
{
	public class MasterPageItem
	{
		public string Title { get; set; }
		public string IconSource { get; set; }
		public Type TargetType { get; set; }
        public Estabelecimento Estabelecimento { get; set; }

		public MasterPageItem()
		{

		}
	}
}
