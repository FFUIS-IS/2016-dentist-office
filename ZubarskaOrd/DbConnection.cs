using System.Data.SqlServerCe;
using System.IO;

namespace ZubarskaOrd
{
    class DbConnection
    {
        private static DbConnection instance;

        private SqlCeConnection connection;

        private DbConnection()
        {
            //string dbPassword = File.ReadAllText(@"..\..\config.txt");
            string connectionString = "Data Source=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Database.sdf; Password=database32";
            

            connection = new SqlCeConnection(connectionString);
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

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
