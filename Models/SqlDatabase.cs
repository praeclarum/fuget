using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Fuget
{
	public class SqlDatabase
	{
		SqlConnection connection;

		public SqlDatabase ()
		{
			var connectionString = ConfigurationManager.ConnectionStrings["MainDatabase"].ConnectionString;

			connection = new SqlConnection (connectionString);

			connection.Open ();
		}

		public string Thing { get { return connection.Database; } }
	}
}

