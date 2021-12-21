using System.Data.SqlClient;

namespace TestMSSQL
{
    class DBConnection
    {
        #region Static Variables
        private static SqlConnectionStringBuilder builder;
        private static SqlConnection connection;
        private static string DataSource = "mrhooligan.database.windows.net";
        private static string UserID = "mrhooligan";
        private static string Password = "UFX6vSM8vwfEV4R";
        private static string InitialCatalog = "KhaiStudentControl";
        #endregion

        public static SqlConnection Connect()
        {
            builder = new SqlConnectionStringBuilder(); ;

            builder.DataSource = DataSource;
            builder.UserID = UserID;
            builder.Password = Password;
            builder.InitialCatalog = InitialCatalog;

            connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}
