namespace Models
{
	public static class ProviderFactory
	{
		static ProviderFactory()
		{
		}

		public static System.Data.IDbDataParameter GetParameter(string parameterName, object value)
		{
			System.Data.IDbDataParameter result = null;

			// شناسايی می کنيم که بانک اطلاعاتی ما چسيت؟

			string providerName =
				System.Configuration.ConfigurationManager.AppSettings["PROVIDER"];

			switch (providerName.ToUpper())
			{
				case "SQLSERVER":
				{
					// اگر اس کيو ال سرور بود
					result =
						new System.Data.SqlClient.SqlParameter(parameterName: parameterName, value: value);

					break;
				}

				case "OLEDB":
				{
					result =
						new System.Data.OleDb.OleDbParameter(name: parameterName, value: value);

					break;
				}

				case "ODBC":
				{
					result =
						new System.Data.Odbc.OdbcParameter(name: parameterName, value: value);

					break;
				}
			}

			return (result);
		}
	}
}
