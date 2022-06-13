using System;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public static class ConnectionManager
    {
        private static string ConnectionString { get; set; }

        private static void InitConnectionString()
        {
            //SqlConnectionStringBuilder builder = new()
            //{
            //    DataSource = "WINDOWS - L400AHK",
            //    InitialCatalog = "BookShopDatabase",
            //    IntegratedSecurity = true
            //};
            ConnectionString = @"Data Source = bookdatabaseazure.database.windows.net; Initial Catalog = BookShopDatabase2; User Id = maridatabase; Password = M+a=ser2000kh";
            //ConnectionString = @"Data Source = WINDOWS - L400AHK\SQLEXPRESS; Initial Catalog = StudentPortal; Integrated Security = True";
            //ConnectionString = builder.ConnectionString;
        }

        public static SqlConnection CreateConnection()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                InitConnectionString();
            return new SqlConnection(ConnectionString);
        }
    }
}