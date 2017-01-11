using System.Data.SqlClient;
using System.IO;

namespace ZubarskaOrd
{
    class DbConnection
    {
        private static DbConnection instance;

        private SqlConnection connection;

        private DbConnection()
        {
            //string dbPassword = File.ReadAllText(@"..\..\config.txt");
            string connectionString = @"Data Source=..\..\..\Database.sdf;Password=database32";

            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbConnection();

                return instance;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
