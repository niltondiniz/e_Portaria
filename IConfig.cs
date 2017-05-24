using System;
using SQLite.Net.Interop;

namespace ePortaria
{
	public interface IConfig
	{
		string DiretorioDB { get; }
		ISQLitePlatform Plataforma { get; }

	}
}
