using System;
namespace ePortaria
{
	public interface IDataBaseConnection
	{
		SQLite.Net.SQLiteConnection DBConnection();
	}
}
