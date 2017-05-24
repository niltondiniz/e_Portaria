using System;
namespace ePortaria.Model
{
	public class Response
	{
		public int code { get; set; }
		public string message { get; set; }
		public Data data { get; set; }
	}
}
