using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FactoryDesignPattern
{
    public static class DatabaseConnectionFactory
    {
        public static IDatabaseConnection CreateDatabaseConnection()
        {
            string[] foundValuesInConfig = ConfigurationManager.AppSettings.GetValues("DatabaseType");
            if (foundValuesInConfig != null && foundValuesInConfig.Length >= 1)
            {
                string dbType = foundValuesInConfig[0];
                if (dbType.Equals("Oracle"))
                    return new OracleDatabaseConnection();
                else if (dbType.Equals("PostgreSQL"))
                    return new PostgreSQLConnection();
                else
                    return new SQLServerDatabaseConnection();
            }
            else
                throw new Exception("Unknown DatabaseType. Please define it in the application configuration file.");

        }
    }
}
